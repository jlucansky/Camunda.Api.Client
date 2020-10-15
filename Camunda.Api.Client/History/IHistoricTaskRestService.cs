using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricTaskRestService
    {
        [Post("/history/task")]
        Task<List<HistoricTask>> GetList([Body] HistoricTaskQuery query, int? firstResult, int? maxResults);

        [Post("/history/task/count")]
        Task<CountResult> GetListCount([Body] HistoricTaskQuery query);
    }
}
