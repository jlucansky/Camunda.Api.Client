using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.History
{
    public class HistoricUserOperationLogQuery : QueryParameters
    {
        /// <summary>
        /// Filter by deployment id.
        /// </summary>
        public string DeploymentId;

        /// <summary>
        ///  Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId;

        /// <summary>
        ///  Filter by process definition key.
        /// </summary>
        public string ProcessDefinitionKey;

        /// <summary>
        ///  Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId;

        /// <summary>
        ///  Filter by execution id.
        /// </summary>
        public string ExecutionId;

        /// <summary>
        ///  Filter by case definition id.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        ///  Filter by case instance id.
        /// </summary>
        public string CaseInstanceId;

        /// <summary>
        ///  Filter by case execution id.
        /// </summary>
        public string CaseExecutionId;

        /// <summary>
        /// Only include operations on this task.
        /// </summary>
        public string TaskId;

        /// <summary>
        ///  Filter by job id.
        /// </summary>
        public string JobId;

        /// <summary>
        ///  Filter by job definition id.
        /// </summary>
        public string JobDefinitionId;

        /// <summary>
        /// Only include operations of this user.
        /// </summary>
        public string UserId;

        /// <summary>
        ///  Filter by the id of the operation. This allows fetching of multiple entries which are part of a composite operation.
        /// </summary>
        public string OperationId;

        /// <summary>
        ///  Filter by the type of the operation like Claim or Delegate. See the Javadoc for a list of available operation types.
        /// </summary>
        public string OperationType;

        /// <summary>
        ///  Filter by the type of the entity that was affected by this operation, possible values are Task, Attachment or IdentityLink.
        /// </summary>
        public string EntityType;

        /// <summary>
        ///  Filter by types of the entities that was affected by this operation, possible values are Task, Attachment or IdentityLink.
        /// </summary>
        [JsonProperty("entityTypeIn")]
        public List<string> EntityTypes;

        /// <summary>
        /// Filter by the category that this operation is associated with, possible values are TaskWorker, Admin or Operator.
        /// </summary>
        public string Category;

        /// <summary>
        /// Filter by the categories that this operation is associated with, possible values are TaskWorker, Admin or Operator.
        /// </summary>
        [JsonProperty("categoryIn")]
        public List<string> Categories;

        /// <summary>
        ///  Only include operations that changed this property, e.g., owner or assignee.
        /// </summary>
        public string Property;

        /// <summary>
        ///  Restrict to entries that were created after the given timestamp.By default*, the timestamp must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2014-02-25T14:58:37.000+0200.
        /// </summary>
        public DateTime? AfterTimestamp;

        /// <summary>
        ///  Restrict to entries that were created before the given timestamp.By default*, the timestamp must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2014-02-25T14:58:37.000+0200.
        /// </summary>
        public DateTime? BeforeTimestamp;

        /// <summary>
        /// Sort the results by a given criterion. At the moment the query only supports sorting based on the timestamp.
        /// </summary>
        public HistoricUserOperationLogQuerySorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum HistoricUserOperationLogQuerySorting
    {
        Timestamp
    }
}