using System;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseActivityInstance
    {
        // The id of the case activity instance.
        public string Id;

        // The id of the parent case activity instance.
        public string ParentCaseActivityInstanceId;

        // The id of the case activity that this object is an instance of.
        public string CaseActivityId;

        // The name of the case activity that this object is an instance of.
        public string CaseActivityName;

        // The type of the activity this case execution belongs to.
        public string CaseActivityType;

        // The id of the case definition that this case activity instance belongs to.
        public string CaseDefinitionId;

        // The id of the case instance that this case activity instance belongs to.
        public string CaseInstanceId;

        // The id of the case execution that executed this case activity instance.
        public string CaseExecutionId;

        // The id of the task that is associated to this case activity instance. Is only set if the case activity is a human task.
        public string TaskId;

        // The id of the called process instance.Is only set if the case activity is a process task.
        public string CalledProcessInstanceId;

        // The id of the called case instance.Is only set if the case activity is a case task.
        public string CalledCaseInstanceId;

        // The time the instance was created. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        public DateTime CreateTime;

        // The time the instance ended.Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        public DateTime EndTime;

        // The time the instance took to finish (in milliseconds).
        public int DurationInMillis;

        // If true, this case activity instance is required.
        public bool Required;

        // If true, this case activity instance is repeatable.
        public bool Repeatable;

        // If true, this case activity instance is a repetition.
        public bool Repetition;

        // If true, this case activity instance is available.
        public bool Available;

        // If true, this case activity instance is enabled.
        public bool Enabled;

        // If true, this case activity instance is disabled.
        public bool Disabled;

        // If true, this case activity instance is active.
        public bool Active;

        // If true, this case activity instance is failed.
        public bool Failed;

        // If true, this case activity instance is suspended.
        public bool Suspended;

        // If true, this case activity instance is completed.
        public bool Completed;

        // If true, this case activity instance is terminated.
        public bool Terminated;

        // The tenant id of the case activity instance.
        public string TenantId;
    }
}