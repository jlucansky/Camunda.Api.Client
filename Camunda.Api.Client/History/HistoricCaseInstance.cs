using System;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseInstance
    {
        /// <summary>
        /// The id of the case instance.
        /// </summary>
        public string Id;

        /// <summary>
        /// If true, this case instance is active.
        /// </summary>
        public bool Active;

        /// <summary>
        /// The business key of the case instance.
        /// </summary>
        public string BusinessKey;

        /// <summary>
        /// The id of the case definition that this case instance belongs to.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        /// The key of the case definition that this case instance belongs to.
        /// </summary>
        public string CaseDefinitionKey;

        /// <summary>
        /// The name of the case definition that this case instance belongs to.
        /// </summary>
        public string CaseDefinitionName;

        /// <summary>
        /// If true, this case instance is closed.
        /// </summary>
        public bool Closed;

        /// <summary>
        /// The time the instance was closed. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public DateTime CloseTime;

        /// <summary>
        /// If true, this case instance is completed.
        /// </summary>
        public bool Completed;

        /// <summary>
        /// The time the instance was created. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public DateTime CreateTime;

        /// <summary>
        /// The id of the user who created the case instance.
        /// </summary>
        public string CreateUserId;

        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        public int DurationInMillis;

        /// <summary>
        /// The id of the parent case instance, if it exists.
        /// </summary>
        public string SuperCaseInstanceId;

        /// <summary>
        /// The id of the parent process instance, if it exists.
        /// </summary>
        public string SuperProcessInstanceId;

        /// <summary>
        /// The tenant id of the case instance.
        /// </summary>
        public string TenantId;

        /// <summary>
        /// If true, this case instance is terminated.
        /// </summary>
        public bool Terminated;

        public override string ToString() => Id;
    }
}