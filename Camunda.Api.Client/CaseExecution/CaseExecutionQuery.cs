using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.CaseExecution
{
    public class CaseExecutionQuery : QueryParameters
    {
        /// <summary>
        /// Filter by a case execution id.
        /// </summary>
        public string CaseExecutionId;

        /// <summary>
        /// Filter by a case instance id.
        /// </summary>
        public string CaseInstanceId;

        /// <summary>
        /// Filter by the business key of the case instances the case executions belong to.
        /// </summary>
        public string BusinessKey;

        /// <summary>
        /// Filter by the case definition the case executions run on.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        /// Filter by the key of the case definition the case executions run on.
        /// </summary>
        public string CaseDefinitionKey;

        /// <summary>
        /// Filter by the id of the activity the case execution currently executes.
        /// </summary>
        public string ActivityId;

        /// <summary>
        /// Only include required case executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Required;

        /// <summary>
        /// Only include repeatable case executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Repeatable;

        /// <summary>
        /// Only include case executions which are repetitions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Repetition;

        /// <summary>
        /// Only include active case executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Active;

        /// <summary>
        /// Only include enabled case executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Enabled;

        /// <summary>
        /// Only include disabled case executions. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool? Disabled;

        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A case execution must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = new List<string>();

        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/> parameter.
        /// </summary>
        public CaseExecutionQuerySorting SortBy;

        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum CaseExecutionQuerySorting
    {
        CaseExecutionId,
        CaseDefinitionKey,
        CaseDefinitionId,
        TenantId
    }
}
