using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class HistoricTask
    {
        /// <summary>
        /// The task id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The key of the process definition the task belongs to.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// The id of the process definition the task belongs to.
        /// </summary>
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// The id of the process instance the task belongs to.
        /// </summary>
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// The id of the execution the task belongs to.
        /// </summary>
        public string ExecutionId { get; set; }

        /// <summary>
        /// The key of the case definition the task belongs to.
        /// </summary>
        public string CaseDefinitionKey { get; set; }

        /// <summary>
        /// The id of the case definition the task belongs to.
        /// </summary>
        public string CaseDefinitionId { get; set; }

        /// <summary>
        /// The id of the case instance the task belongs to.
        /// </summary>
        public string CaseInstanceId { get; set; }

        /// <summary>
        /// The id of the case execution the task belongs to.
        /// </summary>
        public string CaseExecutionId { get; set; }

        /// <summary>
        /// The id of the activity that this object is an instance of.
        /// </summary>
        public string ActivityInstanceId { get; set; }

        /// <summary>
        /// The task name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The task's description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The task's delete reason.
        /// </summary>
        public string DeleteReason { get; set; }

        /// <summary>
        /// The owner's id.
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// The assignee's id.
        /// </summary>
        public string Assignee { get; set; }

        /// <summary>
        /// The time the task was started.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The time the task ended.
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// The time the task took to finish (in milliseconds).
        /// </summary>
        public long Duration { get; set; }

        /// <summary>
        /// The task's key.
        /// </summary>
        public string TaskDefinitionKey { get; set; }

        /// <summary>
        /// The task's priority.
        /// </summary>
        public long Priority { get; set; }

        /// <summary>
        /// The task's due date.
        /// </summary>
        public DateTime Due { get; set; }

        /// <summary>
        /// The id of the parent task, if this task is a subtask.
        /// </summary>
        public string ParentTaskId { get; set; }

        /// <summary>
        /// The follow-up date for the task.
        /// </summary>
        public DateTime FollowUp { get; set; }

        /// <summary>
        /// The tenant id of the task instance.
        /// </summary>
        public string TenantId { get; set; }
    }
}
