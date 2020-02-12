using System;

namespace Camunda.Api.Client.ExternalTask
{
    public class ExternalTaskInfo
    {
        /// <summary>
        /// The id of the activity that this external task belongs to.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// The id of the activity instance that the external task belongs to.
        /// </summary>
        public string ActivityInstanceId;
        /// <summary>
        /// The error message that was supplied when the last failure of this task was reported.
        /// </summary>
        public string ErrorMessage;
        /// <summary>
        /// The error details submitted with the latest reported failure executing this task.
        /// <c>null</c> if no failure was reported previously or if no error details was submitted.
        /// </summary>
        public string ErrorDetails;
        /// <summary>
        /// The id of the execution that the external task belongs to.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The external task's id.
        /// </summary>
        public string Id;
        /// <summary>
        /// The date that the task's most recent lock expires or has expired.
        /// </summary>
        public DateTime? LockExpirationTime;
        /// <summary>
        /// The id of the process definition the external task is defined in.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The key of the process definition the external task is defined in.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The id of the process instance the external task belongs to.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The number of retries the task currently has left.
        /// </summary>
        public int? Retries;
        /// <summary>
        /// A flag indicating whether the external task is suspended or not.
        /// </summary>
        public bool Suspended;
        /// <summary>
        /// The id of the worker that posesses or posessed the most recent lock.
        /// </summary>
        public string WorkerId;
        /// <summary>
        /// The external task's topic name.
        /// </summary>
        public string TopicName;
        /// <summary>
        /// The business key of the process instance the external task belongs to.
        /// </summary>
        public string BusinessKey;
        /// <summary>
        /// The id of the tenant the external task belongs to.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// The priority of the external task.
        /// </summary>
        public long Priority;

        public override string ToString() => Id;
    }
}
