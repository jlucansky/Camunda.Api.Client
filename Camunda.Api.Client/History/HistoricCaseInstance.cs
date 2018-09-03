using System;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseInstance
    {
        //id String  The id of the case instance.
        public string Id;

        //businessKey String  The business key of the case instance.
        public string BusinessKey;

        //caseDefinitionName String  The name of the case definition that this case instance belongs to.
        public string CaseDefinitionName;

        //caseDefinitionKey String  The key of the case definition that this case instance belongs to.
        public string CaseDefinitionKey;

        //caseDefinitionId String  The id of the case definition that this case instance belongs to.
        public string CaseDefinitionId;

        //createTime String  The time the instance was created.Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        public DateTime CreateTime;

        //closeTime String  The time the instance was closed. Default format* yyyy-MM-dd'T'HH:mm:ss.SSSZ.
        public DateTime? CloseTime;

        //durationInMillis Number  The time the instance took to finish (in milliseconds).
        public int DurationInMillis;

        //createUserId String  The id of the user who created the case instance.
        public string CreateUserId;

        //superCaseInstanceId String  The id of the parent case instance, if it exists.
        public string SuperCaseInstanceId;

        //superProcessInstanceId  String The id of the parent process instance, if it exists.
        public string SuperProcessInstanceId;

        //tenantId String  The tenant id of the case instance.
        public string TenantId;

        //active Boolean     If true, this case instance is active.
        public bool Active;

        //completed Boolean     If true, this case instance is completed.
        public bool Completed;

        //terminated Boolean     If true, this case instance is terminated.
        public bool Terminated;

        //closed Boolean     If true, this case instance is closed.
        public bool Closed;

        public override string ToString() => Id;
    }
}