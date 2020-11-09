using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricExternalTaskLogRestService
    {
        [Post("/history/external-task-log")]
        Task<List<HistoricExternalTaskLog>> GetList([Body] HistoricExternalTaskLogQuery query, int? firstResult, int? maxResults);

        [Post("/history/external-task-log/count")]
        Task<CountResult> GetListCount([Body] HistoricExternalTaskLogQuery query);

        [Get("/history/external-task-log/{id}")]
        Task<HistoricExternalTaskLog> Get(string id);

        [Get("/history/external-task-log/{id}/error-details")]
        Task<HttpResponseMessage> GetErrorDetails(string id);
    }
}
