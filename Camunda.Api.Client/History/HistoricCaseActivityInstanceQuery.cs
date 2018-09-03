namespace Camunda.Api.Client.History
{
    public class HistoricCaseActivityInstanceQuery : SortableQuery<HistoricCaseActivityInstanceQuerySorting, HistoricCaseActivityInstanceQuery>
    {
        //caseActivityInstanceId Filter by case activity instance id.
        //caseActivityInstanceIdIn Only include case activity instances which belong to one of the passed and comma-separated activity instance ids.

        /// <summary>
        /// Filter by case instance id.
        /// </summary>
        public string CaseInstanceId;

        //caseDefinitionId Filter by case definition id.
        //caseExecutionId Filter by the id of the case execution that executed the case activity instance.
        //caseActivityId Filter by the case activity id (according to CMMN XML).
        //caseActivityIdIn Only include case activity instances which belong to one of the passed and comma-separated activity ids.
        //caseActivityName Filter by the case activity name(according to CMMN XML).
        //caseActivityType Filter by the case activity type(according to CMMN XML).
        //createdBefore Restrict to instances that were created before the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        //createdAfter Restrict to instances that were created after the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        //endedBefore Restrict to instances that ended before the given date.By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        //endedAfter Restrict to instances that ended after the given date. By default*, the date must have the format yyyy-MM-dd'T'HH:mm:ss.SSSZ, e.g., 2013-01-23T14:42:45.000+0200.
        //finished Only include finished case activity instances. Value may only be true, as false is the default behavior.
        //unfinished Only include unfinished case activity instances. Value may only be true, as false is the default behavior.
        //required Only include required case activity instances. Value may only be true, as false is the default behavior.
        //repeatable Only include repeatable case activity instances. Value may only be true, as false is the default behavior.
        //repetition Only include case activity instances which are repetitions.Value may only be true, as false is the default behavior.
        //available Only include available case activity instances. Value may only be true, as false is the default behavior.
        //enabled Only include enabled case activity instances. Value may only be true, as false is the default behavior.
        //disabled Only include disabled case activity instances. Value may only be true, as false is the default behavior.
        //active Only include active case activity instances. Value may only be true, as false is the default behavior.
        //completed Only include completed case activity instances. Value may only be true, as false is the default behavior.
        //terminated Only include terminated case activity instances. Value may only be true, as false is the default behavior.
        //tenantIdIn Filter by a comma-separated list of tenant ids.A case activity instance must have one of the given tenant ids.
        //sortBy Sort the results by a given criterion. Valid values are caseActivityInstanceID, caseInstanceId, caseExecutionId, caseActivityId, caseActivityName, createTime, endTime, duration, caseDefinitionId and tenantId.Must be used in conjunction with the sortOrder parameter.
        //sortOrder Sort the results in a given order.Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
    }

    public enum HistoricCaseActivityInstanceQuerySorting
    {
        //caseActivityInstanceID,
        //caseInstanceId,
        //caseExecutionId,
        //caseActivityId,
        //caseActivityName,
        //createTime,
        //endTime,
        //duration,
        //caseDefinitionId,
        //tenantId
    }
}