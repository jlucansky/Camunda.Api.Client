using System;

namespace Camunda.Api.Client.Incident
{
    public class IncidentInfo
    {
        /// <summary>
        /// The id of the incident.
        /// </summary>
        public string Id;
        /// <summary>
        /// The id of the process definition this incident is associated with.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The key of the process definition this incident is associated with.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the execution this incident is associated with.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The time this incident happened. Has the format yyyy-MM-dd'T'HH:mm:ss.
        /// </summary>
        public DateTime IncidentTimestamp;
        /// <summary>
        /// The type of incident, for example: failedJobs will be returned in case of an incident which identified a failed job during the execution of a process instance.
        /// </summary>
        public string IncidentType;
        /// <summary>
        /// The id of the activity this incident is associated with.
        /// </summary>
        public string ActivityId;
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

        public override string ToString() => Id;
    }
}
