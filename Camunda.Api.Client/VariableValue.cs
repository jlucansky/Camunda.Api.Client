using Iana;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace Camunda.Api.Client
{
    [JsonObject]
    [JsonConverter(typeof(VariableValueJsonConverter))]
    [TypeConverter(typeof(VariableValueTypeConverter))]
    public class VariableValue : IConvertible
    {
        /// <summary>Identifies the file's name as specified on value creation.</summary>
        public const string ValueInfoFileName = "filename";
        /// <summary>Identifies the file's mime type as specified on value creation.</summary>
        public const string ValueInfoFileMimeType = "mimeType";
        /// <summary>Identifies the file's encoding as specified on value creation.</summary>
        public const string ValueInfoFileEncoding = "encoding";
        /// <summary>Identifies the object's type name./// </summary>
        public const string ValueInfoObjectTypeName = "objectTypeName";
        /// <summary>Identifies the format in which the object is serialized.</summary>
        public const string ValueInfoSerializationDataFormat = "serializationDataFormat";

        private const string SerializedTypedObjectTypeName = "dto.SerializedTypedObject";
        private const string JavaObjectTypeName = "java.lang.Object";

        /// <summary>
        /// The value type of the variable.
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public VariableType Type;

        /// <summary>
        /// Object containing additional, value-type-dependent properties.
        /// </summary>
        /// <remarks>
        /// For serialized variables of type Object, the following properties can be provided:
        ///  objectTypeName: A string representation of the object's type name.
        ///  serializationDataFormat: The serialization format used to store the variable.
        /// 
        /// For serialized variables of type File, the following properties can be provided:
        ///  filename: The name of the file.This is not the variable name but the name that will be used when downloading the file again.
        ///  mimetype: The mime type of the file that is being uploaded.
        ///  encoding: The encoding of the file that is being uploaded.
        /// </remarks>
        public Dictionary<string, object> ValueInfo;

        /// <summary>
        /// The variable's value.
        /// </summary>
        [JsonIgnore]
        public object Value;

        [JsonProperty("value"), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private object rawValue
        {
            get
            {
                if (Value != null)
                {
                    if (IsSerializedTypedObject)
                    {
                        return JsonConvert.SerializeObject( // wrapping into SerializedTypedObject
                            new SerializedTypedObject() { Data = JsonConvert.SerializeObject(Value, typeof(object), TypeAwareJsonSerializerSettings) });
                    }
                    else if (Type == VariableType.Object)
                    {
                        // object serialize as a simple JSON
                        return JsonConvert.SerializeObject(Value);
                    }
                }
                return Value;
            }
            set
            {
                if (value != null)
                {
                    if (IsSerializedTypedObject && value is JToken)
                    {
                        // this can throw exception when cannot find assembly...
                        Value = JsonConvert.DeserializeObject(((SerializedTypedObject)GetValue(value, typeof(SerializedTypedObject))).Data, TypeAwareJsonSerializerSettings);
                    }
                    else
                    {
                        Value = value;
                    }
                }
            }
        }

        private static readonly JsonSerializerSettings TypeAwareJsonSerializerSettings =
            new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto };

        private static readonly JsonSerializer TypeAwareJsonSerializer = 
            JsonSerializer.Create(TypeAwareJsonSerializerSettings);

        protected VariableValue() { } // use FromObject method to instantiate

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool IsSerializedTypedObject =>
            Type == VariableType.Object &&
            ValueInfo != null &&
            ValueInfo.ContainsKey(ValueInfoObjectTypeName) &&
            ValueInfo.ContainsKey(ValueInfoSerializationDataFormat) &&
            ValueInfo[ValueInfoObjectTypeName].Equals(SerializedTypedObjectTypeName) &&
            ValueInfo[ValueInfoSerializationDataFormat].Equals(MediaTypes.Application.Json);

        private class VariableValueJsonConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType) => objectType.IsAssignableFrom(typeof(VariableValue));
            public override bool CanRead => true;
            public override bool CanWrite => false; // we are not handling serialization, use default converter

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var target = (VariableValue)Activator.CreateInstance(objectType, true);
                object rawValue = null;

                while (reader.Read() && reader.TokenType != JsonToken.EndObject)
                {
                    if (reader.TokenType == JsonToken.PropertyName)
                    {
                        string property = (string)reader.Value;

                        if (property.Equals(nameof(Value), StringComparison.OrdinalIgnoreCase))
                        {
                            if (target.Type == VariableType.String)
                            {
                                // suppress JSON deserializer type guessing; string values read explicitly as string
                                rawValue = reader.ReadAsString();
                            }
                            else if (target.Type == VariableType.Date)
                            {
                                rawValue = reader.ReadAsDateTime();
                            }
                            else if (target.Type == VariableType.Bytes || target.Type == VariableType.File)
                            {
                                rawValue = Convert.FromBase64String(reader.ReadAsString());
                            }
                            else
                            {
                                reader.Read();
                                rawValue = serializer.Deserialize(reader);
                            }
                        }
                        else if (PopulateMember(property, reader, serializer, target))
                        {
                            // property successfully filled
                        }
                        else
                        {
                            Debug.Assert(false, "Unknown JSON property: " + property);
                        }
                    }
                }

                target.rawValue = rawValue;

                return target;
            }

            protected virtual bool PopulateMember(string memberName, JsonReader reader, JsonSerializer serializer, object target)
            {
                BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy | BindingFlags.IgnoreCase;

                Type targetType = target.GetType();

                FieldInfo fieldInfo = targetType.GetField(memberName, bindingFlags);

                if (fieldInfo != null)
                {
                    reader.Read();
                    fieldInfo.SetValue(target, serializer.Deserialize(reader, fieldInfo.FieldType));
                    return true;
                }
                else 
                {
                    PropertyInfo propInfo = targetType.GetProperty(memberName, bindingFlags);
                    if (propInfo != null)
                    {
                        reader.Read();
                        propInfo.SetValue(target, serializer.Deserialize(reader, propInfo.PropertyType));
                        return true;
                    }
                }

                return false;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            private string StrToCamelCase(string str)
            {
                if (str?.Length > 1)
                    return str.Substring(0, 1).ToLower() + str.Substring(1);
                else
                    return str?.ToLower();
            }
        }

        public override string ToString()
        {
            if (Value == null)
                return "null";
            else if (Value is byte[])
                return $"{{byte[{(Value as byte[]).Length}]}}";

            return Value.ToString();
        }

        /// <summary>
        /// Value instantiation. Underlying value can be primitive .NET type or any class serializable to JSON
        /// </summary>
        public static VariableValue FromObject(object value)
        {
            var val = new VariableValue();
            val.SetTypedValue(value);
            return val;
        }

        /// <summary>
        /// Convert <see cref="Value"/> to desired type.
        /// </summary>
        public T GetValue<T>() => (T)GetValue(typeof(T));

        /// <summary>
        /// Convert <see cref="Value"/> to desired type.
        /// </summary>
        public object GetValue(Type type)
        {
            return GetValue(Value, type);
        }

        static object GetValue(object source, Type type)
        {
            var jval = source as JToken;
            if (jval != null)
                return jval.ToObject(type, TypeAwareJsonSerializer);
            else if (source != null && type.IsAssignableFrom(source.GetType()))
                return source;
            else
                return Convert.ChangeType(source, type, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Set the <see cref="Value"/>, <see cref="Type"/> and <see cref="ValueInfo"/> according to the given value object.
        /// </summary>
        protected void SetTypedValue(object value)
        {
            Value = value;
            Type = VariableType.Object;

            if (value == null)
                Type = VariableType.Null;
            else if (value is string)
                Type = VariableType.String;
            else if (value is DateTime)
                Type = VariableType.Date;
            else if (value is byte[])
                Type = VariableType.Bytes;
            else if (value is bool)
                Type = VariableType.Boolean;
            else if (value is byte || value is sbyte || value is char || value is short)
                Type = VariableType.Short;
            else if (value is int || value is ushort)
                Type = VariableType.Integer;
            else if (value is float || value is double)
                Type = VariableType.Double;
            else if (value is uint || value is long)
                Type = VariableType.Long;
            else if (value is ulong || value is decimal)
                Type = VariableType.Number;

            if (Type == VariableType.Object) {
                ValueInfo = new Dictionary<string, object>()
                {
                    [ValueInfoSerializationDataFormat] = MediaTypes.Application.Json,
                    [ValueInfoObjectTypeName] = JavaObjectTypeName
                };
            }
        }

        /// <summary>
        /// <see cref="Value"/> will be serialized with <see cref="SerializedTypedObject"/> wrapper.
        /// JSON serialization uses setting <see cref="TypeNameHandling.Auto"/> resulting in JSON with $type
        /// </summary>
        public void EnableTypedObject()
        {
            ValueInfo = new Dictionary<string, object>()
            {
                [ValueInfoSerializationDataFormat] = MediaTypes.Application.Json,
                [ValueInfoObjectTypeName] = SerializedTypedObjectTypeName
            };
        }

        TypeCode IConvertible.GetTypeCode() => Convert.GetTypeCode(Value);
        bool IConvertible.ToBoolean(IFormatProvider provider) => Convert.ToBoolean(Value, provider);
        char IConvertible.ToChar(IFormatProvider provider) => Convert.ToChar(Value, provider);
        sbyte IConvertible.ToSByte(IFormatProvider provider) => Convert.ToSByte(Value, provider);
        byte IConvertible.ToByte(IFormatProvider provider) => Convert.ToByte(Value, provider);
        short IConvertible.ToInt16(IFormatProvider provider) => Convert.ToInt16(Value, provider);
        ushort IConvertible.ToUInt16(IFormatProvider provider) => Convert.ToUInt16(Value, provider);
        int IConvertible.ToInt32(IFormatProvider provider) => Convert.ToInt32(Value, provider);
        uint IConvertible.ToUInt32(IFormatProvider provider) => Convert.ToUInt32(Value, provider);
        long IConvertible.ToInt64(IFormatProvider provider) => Convert.ToInt64(Value, provider);
        ulong IConvertible.ToUInt64(IFormatProvider provider) => Convert.ToUInt64(Value, provider);
        float IConvertible.ToSingle(IFormatProvider provider) => Convert.ToSingle(Value, provider);
        double IConvertible.ToDouble(IFormatProvider provider) => Convert.ToDouble(Value, provider);
        decimal IConvertible.ToDecimal(IFormatProvider provider) => Convert.ToDecimal(Value, provider);
        DateTime IConvertible.ToDateTime(IFormatProvider provider) => Convert.ToDateTime(Value, provider);
        string IConvertible.ToString(IFormatProvider provider) => Convert.ToString(Value, provider);
        object IConvertible.ToType(Type conversionType, IFormatProvider provider) => GetValue(conversionType);

        private class SerializedTypedObject
        {
            [JsonProperty("data")] public string Data;
        }

    }

    public enum VariableType
    {
        Null,
        String,
        Boolean,
        Integer,
        Short,
        Long,
        Double,
        Number,
        Date,
        Bytes,
        File,
        Object
    }

    public enum BinaryVariableType
    {
        Bytes = VariableType.Bytes,
        File = VariableType.File
    }

    class VariableValueTypeConverter : System.ComponentModel.TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return true;
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return true;
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            VariableValue vv = (VariableValue)value;
            return vv.GetValue(destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return VariableValue.FromObject(value);
        }

    }
}
