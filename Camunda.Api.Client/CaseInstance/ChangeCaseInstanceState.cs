#region Usings

using System.Collections.Generic;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class ChangeCaseInstanceState
    {
        public Dictionary<string, CaseInstanceVariableValue> Variables;

        public List<CaseInstanceDeleteVariable> Deletions;
    }
}
