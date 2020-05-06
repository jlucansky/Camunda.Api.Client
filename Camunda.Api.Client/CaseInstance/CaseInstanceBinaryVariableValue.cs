#region Usings

using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceBinaryVariableValue
    {
        [JsonProperty("data")]
        public string Data;

        [JsonProperty("valueType")]
        public BinaryVariableType ValueType;
    }
}
