using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricJobLogQuery : SortableQuery<HistoricJobLogQuerySorting, HistoricJobLogQuery>
    {
        /// <summary>
        /// Filter by historic job log id.
        /// </summary>
        public string LogId;
        /// <summary>
        /// Filter by job id.
        /// </summary>
        public string JobId;
        /// <summary>
        /// Filter by job exception message.
        /// </summary>
        public string JobExceptionMessage;
        /// <summary>
        /// Filter by job definition id.
        /// </summary>
        public string JobDefinitionId;
        /// <summary>
        /// Filter by job definition type.
        /// </summary>
        public string JobDefinitionType;
        /// <summary>
        /// Filter by job definition configuration.
        /// </summary>
        public string JobDefinitionConfiguration;
        /// <summary>
        /// Only include historic job logs which belong to one of the passed activity ids.
        /// </summary>
        [JsonProperty("activityIdIn")]
        public List<string> ActivityIds;
        /// <summary>
        /// Only include historic job logs which belong to one of the passed execution ids.
        /// </summary>
        [JsonProperty("executionIdIn")]
        public List<string> ExecutionIds;
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// Filter by process definition key.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// Filter by deployment id.
        /// </summary>
        public string DeploymentId;
        /// <summary>
        /// Only include creation logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool CreationLog;
        /// <summary>
        /// Only include failure logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool FailureLog;
        /// <summary>
        /// Only include success logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool SuccessLog;
        /// <summary>
        /// Only include deletion logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool DeletionLog;
        /// <summary>
        /// Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long JobPriorityHigherThanOrEquals;
        /// <summary>
        /// Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long JobPriorityLowerThanOrEquals;
        /// <summary>
        /// Only include historic job log entries which belong to one of the passed and comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;
    }

    public enum HistoricJobLogQuerySorting
    {
        JobId,
        JobDefinitionId,
        JobDueDate,
        JobRetries,
        JobPriority,
        ActivityId,
        Timestamp,
        ExecutionId,
        ProcessInstanceId,
        ProcessDefinitionId,
        ProcessDefinitionKey,
        DeploymentId,
        Occurrence,
        TenantId
    }
}
