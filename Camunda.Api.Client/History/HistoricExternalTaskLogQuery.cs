using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Camunda.Api.Client.History
{
    public class HistoricExternalTaskLogQuery : SortableQuery<HistoricExternalTaskTaskSorting, HistoricExternalTaskLogQuery>
    {
        /// <summary>
        /// Filter by historic external task log id.
        /// </summary>
        public string LogId;

        /// <summary>
        /// Filter by external task id.
        /// </summary>
        public string ExternalTaskId;

        /// <summary>
        /// Filter by an external task topic.
        /// </summary>
        public string TopicName;

        /// <summary>
        /// Filter by the id of the worker that the task was most recently locked by. 
        /// </summary>
        public string WorkerId;

        /// <summary>
        /// Filter by external task exception message.  
        /// </summary>
        public string ErrorMessage;

        /// <summary>
        /// Only include historic external task logs which belong to one of the passed activity ids. 
        /// </summary>
        [JsonProperty("activityIdIn")]
        public List<string> ActivityIds;

        /// <summary>
        /// Only include historic external task logs which belong to one of the passed activity instance ids.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceIds;

        /// <summary>
        /// Only include historic external task logs which belong to one of the passed execution ids.
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
        /// Only include historic external task log entries which belong to one of the passed and comma-separated tenant ids.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;

        /// <summary>
        /// Only include historic external task log entries that belong to no tenant. Value may only be true, as false is the default behavior. 
        /// </summary>
        public bool WithoutTenantId;

        /// <summary>
        /// Only include logs for which the associated external task had a priority lower than or equal to the given value. Value must be a valid long value
        /// </summary>
        public long PriorityLowerThanOrEquals;

        /// <summary>
        /// Only include logs for which the associated external task had a priority higher than or equal to the given value. Value must be a valid long value.
        /// </summary>
        public long PriorityHigherThanOrEquals;

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
        /// 	Only include deletion logs. Value may only be true, as false is the default behavior.
        /// </summary>
        public bool DeletionLog;
    }

    public enum HistoricExternalTaskTaskSorting
    {
        timestamp,
        taskId,
        topicName,
        workerId,
        retries,
        priority,
        activityId,
        activityInstanceId,
        executionId,
        processInstanceId,
        processDefinitionId,
        processDefinitionKey,
        tenantId
    }
}