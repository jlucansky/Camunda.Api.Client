using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class CleanableProcessInstanceReportCount: QueryParameters
    {
        /// <summary>
        /// Filter by process definition ids.Must be a comma-separated list of process definition ids.
        /// </summary>
        [JsonProperty("processDefinitionIdIn")]
        public List<string> ProcessDefinitionIds;

        /// <summary>
        ///  Filter by process definition keys. Must be a comma-separated list of process definition keys.
        /// </summary>
        [JsonProperty("processDefinitionKeyIn")]
        public List<string> ProcessDefinitionKeys;

        /// <summary>
        /// Filter by a comma-separated list of tenant ids.A process definition must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;

        /// <summary>
        ///  Only include process definitions which belong to no tenant. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool WithoutTenantId;

        /// <summary>
        ///  Only include process instances which have more than zero finished instances. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Compact;
    }
}
