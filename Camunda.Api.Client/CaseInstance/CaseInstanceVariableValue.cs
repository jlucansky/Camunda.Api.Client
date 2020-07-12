#region Usings

using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceVariableValue : VariableValue
    {
        [JsonProperty("local")]
        public bool Local;
    }
}
