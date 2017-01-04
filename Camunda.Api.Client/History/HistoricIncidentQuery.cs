using Newtonsoft.Json;
using Refit;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricIncidentQuery : IQueryParameters
    {
        /// <summary>
        /// Restricts to incidents that have the given id.
        /// </summary>
        public string IncidentId;
        /// <summary>
        /// Restricts to incidents that belong to the given incident type. See the User Guide for a list of incident types.
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
        /// Restricts to incidents that are open.
        /// </summary>
        public bool Open;
        /// <summary>
        /// Restricts to incidents that are resolved.
        /// </summary>
        public bool Resolved;
        /// <summary>
        /// Restricts to incidents that are deleted.
        /// </summary>
        public bool Deleted;
        /// <summary>
        /// Restricts to incidents that have one of the given comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;
        /// <summary>
        /// Restricts to incidents that have one of the given comma-separated job definition ids.
        /// </summary>
        [JsonProperty("jobDefinitionIdIn")]
        public List<string> JobDefinitionIds;
        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortBy"/>.
        /// </summary>
        public HistoricIncidentQuerySorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/>.
        /// </summary>
        public SortOrder SortOrder;

        IDictionary<string, string> IQueryParameters.GetParameters() => this.CreateQueryParameters();
    }

    public enum HistoricIncidentQuerySorting
    {
        IncidentId,
        CreateTime,
        EndTime,
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
