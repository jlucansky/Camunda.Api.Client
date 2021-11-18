using System;

namespace Camunda.Api.Client.UserTask
{
    public class UserTask
    {
        /// <summary>
        /// The task name.
        /// </summary>
        public string Name;
        /// <summary>
        /// The user assigned to this task.
        /// </summary>
        public string Assignee;
        /// <summary>
        /// The due date for the task.
        /// </summary>
        public DateTime? Due;
        /// <summary>
        /// The follow-up date for the task.
        /// </summary>
        public DateTime? FollowUp;
        /// <summary>
        /// The delegation state of the task. Possible values are RESOLVED and PENDING.
        /// </summary>
        public DelegationState DelegationState;
        /// <summary>
        /// The task description.
        /// </summary>
        public string Description;
        /// <summary>
        /// The owner of the task.
        /// </summary>
        public string Owner;
        /// <summary>
        /// The id of the parent task, if this task is a subtask.
        /// </summary>
        public string ParentTaskId;
        /// <summary>
        /// The priority of the task.
        /// </summary>
        public int Priority;
        /// <summary>
        /// The id of the case instance the task belongs to.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// If not null, the tenantId for the task.
        /// </summary>
        /// <remarks>The tenant id cannot be changed; only the existing tenant id can be passed.</remarks>
        public string TenantId;
        /// <summary>
        /// Indicates if the task is suspended
        /// </summary>
        public Bool Suspended;

        public override string ToString() => Name;
    }
}
