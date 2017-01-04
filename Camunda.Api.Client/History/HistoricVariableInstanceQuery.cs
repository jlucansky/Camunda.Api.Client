using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricVariableInstanceQuery : SortableQuery<HistoricVariableInstanceQuerySorting, HistoricVariableInstanceQuery>
    {
        /// <summary>
        /// Filter by the process instance the variable belongs to.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// Filter by the case instance the variable belongs to.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// Filter by variable name.
        /// </summary>
        public string VariableName;
        /// <summary>
        /// Restrict to variables with a name like the parameter.
        /// </summary>
        public string VariableNameLike;
        /// <summary>
        /// Filter by variable value. May be <c>String</c>, <c>Number</c> or <c>Boolean</c>.
        /// </summary>
        public object VariableValue;
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed execution ids.
        /// </summary>
        [JsonProperty("executionIdIn")]
        public List<string> ExecutionIds;
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed task ids.
        /// </summary>
        [JsonProperty("taskIdIn")]
        public List<string> TaskIds;
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed activity instance ids.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceIds;
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed case execution ids.
        /// </summary>
        [JsonProperty("CaseExecutionIdIn")]
        public List<string> CaseExecutionIds;
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed case activity ids.
        /// </summary>
        [JsonProperty("caseActivityIdIn")]
        public List<string> CaseActivityIds;
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed process instance ids.
        /// </summary>
        [JsonProperty("processInstanceIdIn")]
        public List<string> ProcessInstanceIds;
        /// <summary>
        /// Only include historic variable instances which belong to one of the passed and comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;
    }

    public enum HistoricVariableInstanceQuerySorting
    {
        InstanceId,
        VariableName,
        TenantId
    }
}
