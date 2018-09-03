using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseInstanceQuery : SortableQuery<HistoricCaseInstanceQuerySorting, HistoricCaseInstanceQuery>
    {
        /// <summary>
        /// Filter by the case definition the instances run on.
        /// </summary>
        public string CaseDefinitionId;

        [JsonProperty("caseActivityIdIn")]
        public List<string> CaseActivityIds;

        /// <summary>
        /// Restrict query to one case instance that has a sub process instance with the given id.
        /// </summary>
        public string SubProcessInstanceId;

        /// <summary>
        /// Only include active case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Active;

        /// <summary>
        /// Only include completed case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Completed;

        /// <summary>
        /// Only include terminated case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Terminated;

        /// <summary>
        /// Only include closed case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Closed;

        /// <summary>
        /// Only include not closed case instances.Value may only be true, as false is the default behavior.
        /// </summary>
        public bool NotClosed;
    }

    public enum HistoricCaseInstanceQuerySorting
    {
        InstanceId,
        DefinitionId,
        BusinessKey,
        CreateTime,
        CloseTime,
        Duration,
        TenantId
    }
}