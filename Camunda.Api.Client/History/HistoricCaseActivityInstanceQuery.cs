namespace Camunda.Api.Client.History
{
    public class HistoricCaseActivityInstanceQuery : SortableQuery<HistoricCaseActivityInstanceQuerySorting, HistoricCaseActivityInstanceQuery>
    {
        /// <summary>
        /// Filter by case instance id.
        /// </summary>
        public string CaseInstanceId;
    }

    public enum HistoricCaseActivityInstanceQuerySorting
    {
        CaseActivityInstanceID,
        CaseInstanceId,
        CaseExecutionId,
        CaseActivityId,
        CaseActivityName,
        CreateTime,
        EndTime,
        Duration,
        CaseDefinitionId,
        TenantId
    }
}