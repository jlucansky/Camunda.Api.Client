using System;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseActivityInstance
    {
        /// <summary>
        /// The id of the case activity instance.
        /// </summary>
        public string Id;

        /// <summary>
        /// If true, this case activity instance is active.
        /// </summary>
        public bool Active;

        /// <summary>
        /// If true, this case activity instance is available.
        /// </summary>
        public bool Available;

        /// <summary>
        /// The id of the called case instance. Is only set if the case activity is a case task.
        /// </summary>
        public string CalledCaseInstanceId;

        /// <summary>
        /// The id of the called process instance. Is only set if the case activity is a process task.
        /// </summary>
        public string CalledProcessInstanceId;

        /// <summary>
        /// The id of the case activity that this object is an instance of.
        /// </summary>
        public string CaseActivityId;

        /// <summary>
        /// The name of the case activity that this object is an instance of.
        /// </summary>
        public string CaseActivityName;

        /// <summary>
        /// The type of the activity this case execution belongs to.
        /// </summary>
        public string CaseActivityType;

        /// <summary>
        /// The id of the case definition that this case activity instance belongs to.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        /// The id of the case execution that executed this case activity instance.
        /// </summary>
        public string CaseExecutionId;

        /// <summary>
        /// The id of the case instance that this case activity instance belongs to.
        /// </summary>
        public string CaseInstanceId;

        /// <summary>
        /// If true, this case activity instance is completed.
        /// </summary>
        public bool Completed;

        /// <summary>
        /// The time the instance was created. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public DateTime CreateTime;

        /// <summary>
        /// If true, this case activity instance is disabled.
        /// </summary>
        public bool Disabled;

        /// <summary>
        /// The time the instance took to finish (in milliseconds).
        /// </summary>
        public int DurationInMillis;

        /// <summary>
        /// If true, this case activity instance is enabled.
        /// </summary>
        public bool Enabled;

        /// <summary>
        /// The time the instance ended. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        /// </summary>
        public DateTime EndTime;

        /// <summary>
        /// The id of the parent case activity instance.
        /// </summary>
        public string ParentCaseActivityInstanceId;

        /// <summary>
        /// If true, this case activity instance is repeatable.
        /// </summary>
        public bool Repeatable;

        /// <summary>
        /// If true, this case activity instance is a repetition.
        /// </summary>
        public bool Repetition;

        /// <summary>
        /// If true, this case activity instance is required.
        /// </summary>
        public bool Required;

        /// <summary>
        /// The id of the task that is associated to this case activity instance. Is only set if the case activity is a human task.
        /// </summary>
        public string TaskId;

        /// <summary>
        /// The tenant id of the case activity instance.
        /// </summary>
        public string TenantId;

        /// <summary>
        /// If true, this case activity instance is terminated.
        /// </summary>
        public bool Terminated;

        public override string ToString() => Id;
    }
}