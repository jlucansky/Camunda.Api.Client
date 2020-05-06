#region Usings

using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceQueryVariable
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("operator")]
        public ConditionOperator Operator;

        [JsonProperty("value")] 
        public object Value;
    }
}
