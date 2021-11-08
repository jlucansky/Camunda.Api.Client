using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricUserOperationRestService
    {
        [Get("/history/user-operation/{id}")]
        Task<HistoricUserOperation> Get(string id);

        [Get("/history/user-operation?processInstanceId={processInstanceId}&property=assignee")]
        Task<List<HistoricUserOperation>> GetHistoricAssignmentsOfProcess(string processInstanceId);

        [Get("/history/user-operation?taskId={taskInstanceId}&property=assignee")]
        Task<List<HistoricUserOperation>> GetHistoricAssignmentsOfTask(string taskInstanceId);

    }
}
