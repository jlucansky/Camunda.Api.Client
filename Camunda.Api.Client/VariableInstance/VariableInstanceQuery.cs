using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.VariableInstance
{
    public class VariableInstanceQuery : SortableQuery<VariableInstanceSorting, VariableInstanceQuery>
    {
        /// <summary>
        /// Filter by variable instance name.
        /// </summary>
        public string VariableName;
        /// <summary>
        /// Filter by the variable instance name. The parameter can include the wildcard % to express like-strategy such as: starts with (%name), ends with (name%) or contains (%name%).
        /// </summary>
        public string VariableNameLike;
        /// <summary>
        /// An array to only include variable instances that have the certain values.
        /// </summary>
        public List<VariableQueryParameter> VariableValues;
        /// <summary>
        /// Only include variable instances which belong to one of the passed execution ids.
        /// </summary>
        [JsonProperty("executionIdIn")]
        public List<string> ExecutionId = new List<string>();
        /// <summary>
        /// Only include variable instances which belong to one of the passed process instance ids.
        /// </summary>
        [JsonProperty("processInstanceIdIn")]
        public List<string> ProcessInstanceId = new List<string>();
        /// <summary>
        /// Only include variable instances which belong to one of the passed case execution ids.
        /// </summary>
        [JsonProperty("caseExecutionIdIn")]
        public List<string> CaseExecutionId = new List<string>();
        /// <summary>
        /// Only include variable instances which belong to one of the passed case instance ids.
        /// </summary>
        [JsonProperty("caseInstanceIdIn")]
        public List<string> CaseInstanceId = new List<string>();
        /// <summary>
        /// Only include variable instances which belong to one of the passed task ids.
        /// </summary>
        [JsonProperty("taskIdIn")]
        public List<string> TaskId = new List<string>();
        /// <summary>
        /// Only select variables instances which have on of the variable scope ids.
        /// </summary>
        [JsonProperty("variableScopeIdIn")]
        public List<string> VariableScopeId = new List<string>();
        /// <summary>
        /// Only include variable instances which belong to one of the passed activity instance ids.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceId = new List<string>();
        /// <summary>
        /// Only select variable instances with one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = new List<string>();
    }

    public enum VariableInstanceSorting
    {
        VariableName,
        VariableType,
        ActivityInstanceId,
        TenantId
    }
}
