#region Usings

using System.Collections.Generic;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceModifications
    {
        [JsonProperty("modifications")]
        public Dictionary<string, VariableValue> Modifications;
         
        [JsonProperty("deletions")]
        public List<CaseInstanceDeleteVariable> Deletions;
    }
}
