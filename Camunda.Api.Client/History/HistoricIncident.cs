using System;

namespace Camunda.Api.Client.History
{
    public class HistoricIncident
    {
        /// <summary>
        /// The id of the incident.
        /// </summary>
        public string Id;
        /// <summary>
        /// The key of the process definition this incident is associated with.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The id of the process definition this incident is associated with.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The id of the process instance this incident is associated with.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the execution this incident is associated with.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The time this incident happened.
        /// </summary>
        public DateTime CreateTime;
        /// <summary>
        /// The time this incident has been deleted or resolved.
        /// </summary>
        public DateTime? EndTime;
        /// <summary>
        /// The type of incident, for example: failedJobs will be returned in case of an incident which identified a failed job during
        /// </summary>
        public string IncidentType;
        /// <summary>
        /// The id of the activity this incident is associated with.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// The id of the activity on which the last exception occurred.
        /// </summary>
        public string FailedActivityId;
        /// <summary>
        /// The id of the associated cause incident which has been triggered.
        /// </summary>
        public string CauseIncidentId;
        /// <summary>
        /// The id of the associated root cause incident which has been triggered.
        /// </summary>
        public string RootCauseIncidentId;
        /// <summary>
        /// The payload of this incident.
        /// </summary>
        public string Configuration;
        /// <summary>
        /// The message of this incident.
        /// </summary>
        public string IncidentMessage;
        /// <summary>
        /// The id of the tenant this incident is associated with.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// The job definition id the incident is associated with.
        /// </summary>
        public string JobDefinitionId;
        /// <summary>
        /// If true, this incident is open.
        /// </summary>
        public bool Open;
        /// <summary>
        /// If true, this incident has been deleted.
        /// </summary>
        public bool Deleted;
        /// <summary>
        /// If true, this incident has been resolved.
        /// </summary>
        public bool Resolved;

        public override string ToString() => Id;
    }
}
