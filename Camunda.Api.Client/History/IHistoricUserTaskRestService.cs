using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricUserTaskRestService
    {
        [Post("/history/task")]
        Task<List<HistoricTask>> GetList([Body] HistoricTaskQuery query, int? firstResult, int? maxResults);

        [Post("/history/task/count")]
        Task<CountResult> GetListCount([Body] HistoricTaskQuery query);

        [Get("/history/task/report")]
        Task<List<DurationReportResult>> GetDurationReport(QueryDictionary query);

        [Get("/history/task/report")]
        Task<List<CountReportResult>> GetCountReport(QueryDictionary query);
    }
}
