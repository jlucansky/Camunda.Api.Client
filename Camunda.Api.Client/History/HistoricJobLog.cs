using System;

namespace Camunda.Api.Client.History
{
    public class HistoricJobLog
    {
        /// <summary>
        /// The id of the log entry.
        /// </summary>
        public string Id;
        /// <summary>
        /// The time when the log entry has been written.
        /// </summary>
        public DateTime Timestamp;
        /// <summary>
        /// The id of the associated job.
        /// </summary>
        public string JobId;
        /// <summary>
        /// The date on which the associated job is supposed to be processed.
        /// </summary>
        public DateTime JobDueDate;
        /// <summary>
        /// The number of retries the associated job has left.
        /// </summary>
        public int JobRetries;
        /// <summary>
        /// The execution priority the job had when the log entry was created.
        /// </summary>
        public long JobPriority;
        /// <summary>
        /// The message of the exception that occurred by executing the associated job.
        /// </summary>
        public string JobExceptionMessage;
        /// <summary>
        /// The id of the job definition on which the associated job was created.
        /// </summary>
        public string JobDefinitionId;
        /// <summary>
        /// The job definition type of the associated job.
        /// </summary>
        public string JobDefinitionType;
        /// <summary>
        /// The job definition configuration type of the associated job.
        /// </summary>
        public string JobDefinitionConfiguration;
        /// <summary>
        /// The id of the activity on which the associated job was created.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// The execution id on which the associated job was created.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The id of the process instance on which the associated job was created.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the process definition which the associated job belongs to.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The key of the process definition which the associated job belongs to.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The id of the deployment which the associated job belongs to.
        /// </summary>
        public string DeploymentId;
        /// <summary>
        /// The id of the tenant that this historic job log entry belongs to.
        /// </summary>
        public string TenantId;
        /// <summary>
        /// A flag indicating whether this log represents the creation of the associated job.
        /// </summary>
        public bool CreationLog;
        /// <summary>
        /// A flag indicating whether this log represents the failed execution of the associated job.
        /// </summary>
        public bool FailureLog;
        /// <summary>
        /// A flag indicating whether this log represents the successful execution of the associated job.
        /// </summary>
        public bool SuccessLog;
        /// <summary>
        /// A flag indicating whether this log represents the deletion of the associated job.
        /// </summary>
        public bool DeletionLog;

        public override string ToString() => Id;
    }
}
