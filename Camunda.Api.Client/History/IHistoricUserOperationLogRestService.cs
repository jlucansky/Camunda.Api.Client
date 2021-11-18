using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricUserOperationLogRestService
    {
        [Get("/history/user-operation/{id}")]
        Task<HistoricUserOperationLog> Get(string id);

        [Get("/history/user-operation?processInstanceId={processInstanceId}&property=assignee")]
        Task<List<HistoricUserOperationLog>> GetHistoricAssignmentsOfProcess(string processInstanceId);

        [Get("/history/user-operation?taskId={taskInstanceId}&property=assignee")]
        Task<List<HistoricUserOperationLog>> GetHistoricAssignmentsOfTask(string taskInstanceId);

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
