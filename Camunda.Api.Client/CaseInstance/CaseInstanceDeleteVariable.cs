#region Usings

using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceDeleteVariable
    {
        [JsonProperty("name")]
        public string Name;
    }
}
