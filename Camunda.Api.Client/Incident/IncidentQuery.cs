using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.Incident
{
    public class IncidentQuery : QueryParameters
    {
        /// <summary>
        /// Restricts to incidents that have the given id.
        /// </summary>
        public string IncidentId;
        /// <summary>
        /// Restricts to incidents that belong to the given incident type.
        /// </summary>
        public string IncidentType;
        /// <summary>
        /// Restricts to incidents that have the given incident message.
        /// </summary>
        public string IncidentMessage;
        /// <summary>
        /// Restricts to incidents that belong to a process definition with the given id.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// Restricts to incidents that belong to a process instance with the given id.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// Restricts to incidents that belong to an execution with the given id.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// Restricts to incidents that belong to an activity with the given id.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// Restricts to incidents that have the given incident id as cause incident.
        /// </summary>
        public string CauseIncidentId;
        /// <summary>
        /// Restricts to incidents that have the given incident id as root cause incident.
        /// </summary>
        public string RootCauseIncidentId;
        /// <summary>
        /// Restricts to incidents that have the given parameter set as configuration.
        /// </summary>
        public string Configuration;
        /// <summary>
        /// Restricts to incidents that have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds = new List<string>();
        /// <summary>
        /// Restricts to incidents that have one of the given job definition ids.
        /// </summary>
        [JsonProperty("jobDefinitionIdIn")]
        public List<string> JobDefinitionIds = new List<string>();
        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/>.
        /// </summary>
        public IncidentSorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/>.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum IncidentSorting
    {
        IncidentId,
        IncidentTimestamp,
        IncidentType,
        ExecutionId,
        ActivityId,
        ProcessInstanceId,
        ProcessDefinitionId,
        CauseIncidentId,
        RootCauseIncidentId,
        Configuration,
        TenantId
    }

}