using System;

namespace Camunda.Api.Client.History
{
    public class HistoricActivityInstance
    {
        /// <summary>
        /// The id of the activity instance.
        /// </summary>
        public string Id;
        /// <summary>
        /// The id of the parent activity instance, for example a sub process instance.
        /// </summary>
        public string ParentActivityInstanceId;
        /// <summary>
        /// The id of the activity that this object is an instance of.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// The name of the activity that this object is an instance of.
        /// </summary>
        public string ActivityName;
        /// <summary>
        /// The type of the activity that this object is an instance of.
        /// </summary>
        public string ActivityType;
        /// <summary>
        /// The key of the process definition that this activity instance belongs to.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The id of the process definition that this activity instance belongs to.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The id of the process instance that this activity instance belongs to.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the execution that executed this activity instance.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The id of the task that is associated to this activity instance. Is only set if the activity is a user task.
        /// </summary>
        public string TaskId;
        /// <summary>
        /// The id of the called process instance. Is only set if the activity is a call activity and the called instance a process instance.
        /// </summary>
        public string CalledProcessInstanceId;
        /// <summary>
        /// The id of the called case instance. Is only set if the activity is a call activity and the called instance a case instance.
        /// </summary>
        public string CalledCaseInstanceId;
        /// <summary>
        /// The assignee of the task that is associated to this activity instance. Is only set if the activity is a user task.
        /// </summary>
        public string Assignee;
        /// <summary>
        /// The time the instance was started. Has the format yyyy-MM-dd'T'HH:mm:ss.
        /// </summary>
        public DateTime StartTime;
        /// <summary>
        /// The time the instance ended. Has the format yyyy-MM-dd'T'HH:mm:ss.
        /// </summary>
        public DateTime EndTime;
        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        public long DurationInMillis;
        /// <summary>
        /// If true, this activity instance is canceled.
        /// </summary>
        public bool Canceled;
        /// <summary>
        /// If true, this activity instance did complete a BPMN 2.0 scope.
        /// </summary>
        public bool CompleteScope;
        /// <summary>
        /// The tenant id of the activity instance.
        /// </summary>
        public string TenantId;

        public override string ToString() => Id;
    }
}
