using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricProcessInstanceQuery : SortableQuery<HistoricProcessInstanceQuerySorting, HistoricProcessInstanceQuery>
    {
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId;

        /// <summary>
        /// Filter by process instance ids.
        /// </summary>
        public List<string> ProcessInstanceIds;

        /// <summary>
        /// Filter by the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionId;

        /// <summary>
        /// Filter by the name of the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionName;

        /// <summary>
        /// Filter by process definition names that the parameter is a substring of.
        /// </summary>
        public string ProcessDefinitionNameLike;

        /// <summary>
        /// Filter by process instance business key.
        /// </summary>
        [JsonProperty("processInstanceBusinessKey")]
        public string BusinessKey;

        /// <summary>
        /// Filter by process instance business key that the parameter is a substring of.
        /// </summary>
        [JsonProperty("processInstanceBusinessKeyLike")]
        public string BusinessKeyLike;

        /// <summary>
        /// Only include finished process instances.
        /// </summary>
        public bool Finished = false;

        /// <summary>
        /// Only include unfinished process instances.
        /// </summary>
        public bool Unfinished = false;

        /// <summary>
        /// Only include process instances which have an incident.
        /// </summary>
        public bool WithIncidents = false;

        /// <summary>
        /// Only include process instances which have an incident in status either open or resolved. To get all process instances, use the query parameter withIncidents.
        /// </summary>
        public string IncidentStatus;

        /// <summary>
        /// Filter by the incident message. Exact match.
        /// </summary>
        public string IncidentMessage;

        /// <summary>
        /// Filter by the incident message that the parameter is a substring of.
        /// </summary>
        public string IncidentMessageLike;

        /// <summary>
        /// Only include process instances that were started by the given user.
        /// </summary>
        public string StartedBy;

        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given process instance. Takes a process instance id.
        /// </summary>
        public string SuperProcessInstanceId;

        /// <summary>
        /// Restrict query to one process instance that has a sub process instance with the given id.
        /// </summary>
        public string SubProcessInstanceId;

        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id.
        /// </summary>
        public string SuperCaseInstanceId;

        /// <summary>
        /// Restrict query to one process instance that has a sub case instance with the given id.
        /// </summary>
        public string SubCaseInstanceId;

        /// <summary>
        /// Restrict to instances that were started before the given date.
        /// </summary>
        public DateTime? StartedBefore;

        /// <summary>
        /// Restrict to instances that were started after the given date.
        /// </summary>
        public DateTime? StartedAfter;

        /// <summary>
        /// Restrict to instances that were finished before the given date.
        /// </summary>
        public DateTime? FinishedBefore;

        /// <summary>
        /// Restrict to instances that were finished after the given date.
        /// </summary>
        public DateTime? FinishedAfter;

        /// <summary>
        /// Filter by the key of the process definition the instances run on.
        /// </summary>
        public string ProcessDefinitionKey;

        /// <summary>
        /// Exclude instances that belong to a set of process definitions. An array of process definition keys.
        /// </summary>
        public List<string> ProcessDefinitionKeyNotIn;

        /// <summary>
        /// Filter by a list of tenant ids. A process instance must have one of the given tenant ids. Must be an array of Strings.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;

        /// <summary>
        /// Restrict query to all process instances that are sub process instances of the given case instance. Takes a case instance id.
        /// </summary>
        public string CaseInstanceId;

        [JsonProperty("activeActivityIdIn")]
        public List<string> ActiveActivityIds;
    }

    public enum HistoricProcessInstanceQuerySorting
    {
        InstanceId,
        DefinitionId,
        BusinessKey,
        StartTime,
        EndTime,
        Duration,
        TenantId
    }
}