using System.Runtime.Serialization;

namespace Camunda.Api.Client
{
    public class ConditionQueryParameter
    {
        /// <summary>
        /// Comparison operator to be used.
        /// </summary>
        public ConditionOperator Operator;

        /// <summary>
        /// Value may be String, Number or Boolean
        /// </summary>
        public object Value;
    }

    public enum ConditionOperator
    {
        [EnumMember(Value = "eq")]
        Equals,
        [EnumMember(Value = "neq")]
        NotEquals,
        [EnumMember(Value = "gt")]
        GreaterThan,
        [EnumMember(Value = "gteq")]
        GreaterThanOrEquals,
        [EnumMember(Value = "lt")]
        LessThan,
        [EnumMember(Value = "lteq")]
        LessThanOrEquals,
        [EnumMember(Value = "like")]
        Like
    }
}
