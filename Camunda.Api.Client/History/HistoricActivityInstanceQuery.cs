using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Camunda.Api.Client.History
{
    public class HistoricActivityInstanceQuery : SortableQuery<HistoricActivityInstanceQuerySorting, HistoricActivityInstanceQuery>
    {
        /// <summary>
        /// Filter by activity instance id.
        /// </summary>
        public string ActivityInstanceId;
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// Filter by the id of the execution that executed the activity instance.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// Filter by the activity id (according to BPMN 2.0 XML).
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// Filter by the activity name (according to BPMN 2.0 XML).
        /// </summary>
        public string ActivityName;
        /// <summary>
        /// Filter by activity type.
        /// </summary>
        public string ActivityType;
        /// <summary>
        /// Only include activity instances that are user tasks and assigned to a given user.
        /// </summary>
        public string TaskAssignee;
        /// <summary>
        /// Only include finished activity instances.
        /// </summary>
        public bool Finished;
        /// <summary>
        /// Only include unfinished activity instances. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Unfinished;
        /// <summary>
        /// Only include activity instances which completed a scope. 
        /// </summary>
        public bool CompleteScope;
        /// <summary>
        /// Only include canceled activity instances. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool Canceled;
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
        /// Filter by a list of tenant ids. An activity instance must have one of the given tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;
    }

    public enum HistoricActivityInstanceQuerySorting
    {
        ActivityInstanceId,
        InstanceId,
        ExecutionId,
        ActivityId,
        ActivityName,
        ActivityType,
        StartTime,
        EndTime,
        Duration,
        DefinitionId,
        TenantId
    }
}
