using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricUserOperationLogRestService
    {
        [Get("/history/user-operation")]
        Task<List<HistoricUserOperationLog>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/history/user-operation/count")]
        Task<CountResult> GetListCount(QueryDictionary query);

        [Put("/history/user-operation/{operationId}/set-annotation")]
        Task SetAnnotation(string operationId, [Body] HistoricUserOperationLogAnnotation historicUserOperationLogAnnotation);
        
        [Put("/history/user-operation/{operationId}/clear-annotation")]
        Task ClearAnnotation(string operationId);
    }
}
