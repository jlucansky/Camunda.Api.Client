using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.JobDefinition
{
    public class JobDefinitionQuery : SortableQuery<JobDefinitionSorting, JobDefinitionQuery>
    {
        /// <summary>
        /// Filter by job definition id.
        /// </summary>
        public string JobDefinitionId;
        /// <summary>
        /// Only include job definitions which belong to one of the passed activity ids.
        /// </summary>
        [JsonProperty("activityIdIn")]
        public List<string> ActivityIds = new List<string>();
        /// <summary>
        /// Only include job definitions which exist for the given process definition id.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// Only include job definitions which exist for the given process definition key.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// Only include job definitions which exist for the given job type.
        /// </summary>
        public string JobType;
        /// <summary>
        /// Only include job definitions which exist for the given job configuration.
        /// </summary>
        public string JobConfiguration;
        /// <summary>
        /// Only include active job definitions.
        /// </summary>
        public bool Active;
        /// <summary>
        /// Only include suspended job definitions.
        /// </summary>
        public bool Suspended;
        /// <summary>
        /// Only include job definitions that have an overriding job priority defined.
        /// </summary>
        public bool WithOverridingJobPriority;
        /// <summary>
        /// Only include job definitions which belong to one of the passed and comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = new List<string>();
        /// <summary>
        /// Only include job definitions which belongs to no tenant.
        /// </summary>
        public bool WithoutTenantId;
        /// <summary>
        /// Include job definitions which belongs to no tenant. Can be used in combination with tenantIdIn. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool IncludeJobDefinitionsWithoutTenantId;
    }

    public enum JobDefinitionSorting
    {
        JobDefinitionId,
        ActivityId,
        ProcessDefinitionId,
        ProcessDefinitionKey,
        JobType,
        JobConfiguration,
        TenantId
    }
}
