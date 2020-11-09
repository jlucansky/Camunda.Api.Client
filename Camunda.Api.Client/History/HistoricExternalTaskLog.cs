using Camunda.Api.Client.UserTask;
using System;
using System.Runtime.Serialization;

namespace Camunda.Api.Client.History
{
    public class HistoricExternalTaskLog
    {
        /// <summary>
        /// The id of the log entry.
        /// </summary>
        public string Id;

        /// <summary>
        /// The id of the external task.
        /// </summary>
        public string ExternalTaskId;

        /// <summary>
        /// The time when the log entry has been written.
        /// </summary>
        public string Timestamp;

        /// <summary>
        /// The topic name of the associated external task.
        /// </summary>
        public string TopicName;

        /// <summary>
        /// The id of the worker that posessed the most recent lock.
        /// </summary>
        public string WorkerId;

        /// <summary>
        /// The number of retries the associated external task has left.
        /// </summary>
        public int Retries;

        /// <summary>
        /// The execution priority the external task had when the log entry was created.
        /// </summary>
        public int Priority;

        /// <summary>
        /// The message of the error that occurred by executing the associated external task.
        /// </summary>
        public string ErrorMessage;

        /// <summary>
        /// The id of the activity on which the associated external task was created.
        /// </summary>
        public string ActivityId;

        /// <summary>
        /// The id of the activity instance on which the associated external task was created.
        /// </summary>
        public string ActivityInstanceId;

        /// <summary>
        /// The execution id on which the associated external task was created.
        /// </summary>
        public string ExecutionId;

        /// <summary>
        /// The id of the process instance on which the associated external task was created.
        /// </summary>
        public string ProcessInstanceId;

        /// <summary>
        /// The id of the process definition which the associated external task belongs to.
        /// </summary>
        public string ProcessDefinitionId;

        /// <summary>
        /// The key of the process definition which the associated external task belongs to.
        /// </summary>
        public string ProcessDefinitionKey;

        /// <summary>
        /// The id of the tenant that this historic external task log entry belongs to.
        /// </summary>
        public string TenantId;

        /// <summary>
        /// A flag indicating whether this log represents the creation of the associated external task.
        /// </summary>
        public bool CreationLog;

        /// <summary>
        /// A flag indicating whether this log represents the failed execution of the associated external task.
        /// </summary>
        public bool FailureLog;

        /// <summary>
        /// A flag indicating whether this log represents the successful execution of the associated external task.
        /// </summary>
        public bool SuccessLog;

        /// <summary>
        /// A flag indicating whether this log represents the deletion of the associated external task.
        /// </summary>
        public bool DeletionLog;

        /// <summary>
        /// The time after which this log should be removed by the History Cleanup job.Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public string RemovalTime;

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this log.
        /// </summary>
        public string RootProcessInstanceId;
    }
}
