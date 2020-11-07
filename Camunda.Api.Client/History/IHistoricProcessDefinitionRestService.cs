using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricProcessDefinitionRestService
    {
        [Get("/history/process-definition/{id}/statistics")]
        Task<List<HistoricActivityStatisticsResult>> GetHistoricActivityStatistics(string id, QueryDictionary query);

        [Get("/history/process-definition/cleanable-process-instance-report")]
        Task<List<CleanableProcessInstanceReportResult>> GetCleanableProcessInstanceReport(QueryDictionary query);

        [Get("/history/process-definition/cleanable-process-instance-report/count")]
        Task<CountResult> GetCleanableProcessInstanceReportCount(QueryDictionary query);
    }
}
