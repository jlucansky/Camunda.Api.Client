using Newtonsoft.Json.Serialization;

namespace Camunda.Api.Client
{
    internal class StringEnumConverter : Newtonsoft.Json.Converters.StringEnumConverter
    {
        private static CamelCaseNamingStrategy _camelCaseNamingStrategy = new CamelCaseNamingStrategy();

        public StringEnumConverter()
        {
            NamingStrategy = _camelCaseNamingStrategy;
            AllowIntegerValues = false; // integer values are not allowed because they dont't have API origin
        }
    }
}
