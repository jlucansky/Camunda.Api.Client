using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricDetailQuery : QueryParameters
    {
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// Filter by the id of the execution that executed the activity instance.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// Filter by activity instance id.
        /// </summary>
        public string ActivityInstanceId;
        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// Restrict to tasks that belong to a case execution with the given id.
        /// </summary>
        public string CaseExecutionId;
        /// <summary>
        /// Variable instance id
        /// </summary>
        public string VariableInstanceId;
        /// <summary>
        /// Only select variable instances with one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;
        /// <summary>
        /// User operation id
        /// </summary>
        public string UserOperationId;
        /// <summary>
        /// Form fields
        /// </summary>
        public bool? FormFields;
        /// <summary>
        /// Variable updates
        /// </summary>
        public bool? VariableUpdates;
        /// <summary>
        /// Exclude task details
        /// </summary>
        public bool? ExcludeTaskDetails;

        
    }

}
