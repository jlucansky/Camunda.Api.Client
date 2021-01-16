namespace Camunda.Api.Client.History
{
    public class HistoricUserOperationLog
    {
        /// <summary>
        ///   The unique identifier of this log entry.
        /// </summary>
        public string Id;

        /// <summary>
        /// The user who performed this operation.
        /// </summary>
        public string UserId;

        /// <summary>
        ///  Timestamp of this operation.
        /// </summary>
        public string Timestamp;

        /// <summary>
        ///  The unique identifier of this operation.A composite operation that changes multiple properties has a common operationId.
        /// </summary>
        public string OperationId;

        /// <summary>
        /// The type of this operation, e.g., Assign, Claim and so on.
        /// </summary>
        public string OperationType;

        /// <summary>
        /// The type of the entity on which this operation was executed, e.g., Task or Attachment.
        /// </summary>
        public string EntityType;

        /// <summary>
        ///  The name of the category this operation was associated with, e.g., TaskWorker or Admin.
        /// </summary>
        public string Category;

        /// <summary>
        /// An arbitrary annotation set by a user for auditing reasons.
        /// </summary>
        public string Annotation;

        /// <summary>
        /// The property changed by this operation.
        /// </summary>
        public string Property;

        /// <summary>
        ///  The original value of the changed property.
        /// </summary>
        public string OrgValue;

        /// <summary>
        /// The new value of the changed property.
        /// </summary>
        public string NewValue;

        /// <summary>
        /// If not null, the operation is restricted to entities in relation to this deployment.
        /// </summary>
        public string DeploymentId;

        /// <summary>
        ///  If not null, the operation is restricted to entities in relation to this process definition.
        /// </summary>
        public string ProcessDefinitionId;

        /// <summary>
        /// If not null, the operation is restricted to entities in relation to process definitions with this key.
        /// </summary>
        public string ProcessDefinitionKey;

        /// <summary>
        ///  If not null, the operation is restricted to entities in relation to this process instance.
        /// </summary>
        public string ProcessInstanceId;

        /// <summary>
        ///  If not null, the operation is restricted to entities in relation to this execution.
        /// </summary>
        public string ExecutionId;

        /// <summary>
        /// If not null, the operation is restricted to entities in relation to this case definition.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        /// If not null, the operation is restricted to entities in relation to this case instance.
        /// </summary>
        public string CaseInstanceId;

        /// <summary>
        /// If not null, the operation is restricted to entities in relation to this case execution.
        /// </summary>
        public string CaseExecutionId;

        /// <summary>
        ///  If not null, the operation is restricted to entities in relation to this task.
        /// </summary>
        public string TaskId;

        /// <summary>
        /// If not null, the operation is restricted to entities in relation to this job.
        /// </summary>
        public string JobId;

        /// <summary>
        ///  If not null, the operation is restricted to entities in relation to this job definition.
        /// </summary>
        public string JobDefinitionId;

        /// <summary>
        /// The time after which the entry should be removed by the History Cleanup job. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public string RemovalTime;

        /// <summary>
        /// The process instance id of the root process instance that initiated the process containing this entry.
        /// </summary>
        public string RootProcessInstanceId;
    }
}
