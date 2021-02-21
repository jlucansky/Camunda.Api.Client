#region Usings

using System.Collections.Generic;
using Newtonsoft.Json;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceQuery
    {
        public string CaseInstanceId;

        public string BusinessKey;

        public string CaseDefinitionId;

        public string CaseDefinitionKey;

        public string DeploymentId;

        public string SuperProcessInstance;

        public string SubProcessInstance;

        public string SuperCaseInstance;

        public string SubCaseInstance;

        public bool? Active;

        public bool? Completed;

        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;

        public bool? WithoutTenantId;

        public List<VariableQueryParameter> Variables;

        public bool VariableNamesIgnoreCase;

        public bool VariableValuesIgnoreCase;

        public CaseInstanceSorting SortBy;

        public SortOrder SortOrder;
    }
}
