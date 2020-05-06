#region Usings

using System.Collections.Generic;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class ChangeCaseInstanceState
    {
        [JsonProperty("variables")]
        public Dictionary<string, CaseInstanceVariableValue> Variables;

        [JsonProperty("deletions")]
        public List<CaseInstanceDeleteVariable> Deletions;
    }
}
