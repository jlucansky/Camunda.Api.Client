using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ExternalTask
{
    internal interface IExternalTaskRestService
    {
        [Get("/external-task/{externalTaskId}")]
        Task<ExternalTaskInfo> Get(string externalTaskId);

        [Post("/external-task")]
        Task<List<ExternalTaskInfo>> GetList([Body] ExternalTaskQuery query, int? firstResult, int? maxResults);

        [Post("/external-task/count")]
        Task<CountResult> GetListCount([Body] ExternalTaskQuery query);

        [Post("/external-task/fetchAndLock")]
        Task<List<LockedExternalTask>> FetchAndLock([Body] FetchExternalTasks fetching);

        [Put("/external-task/{externalTaskId}/retries")]
        Task SetRetries(string externalTaskId, [Body] RetriesInfo retries);

        [Put("/external-task/{externalTaskId}/priority")]
        Task SetPriority(string externalTaskId, [Body] PriorityInfo priority);

        [Post("/external-task/{externalTaskId}/complete")]
        Task Complete(string externalTaskId, [Body] CompleteExternalTask completeExternalTask);

        [Post("/external-task/{externalTaskId}/bpmnError")]
        Task HandleBpmnError(string externalTaskId, [Body] ExternalTaskBpmnError externalTaskBpmnError);

        [Post("/external-task/{externalTaskId}/failure")]
        Task HandleFailure(string externalTaskId, [Body] ExternalTaskFailure externalTaskFailure);

        [Post("/external-task/{externalTaskId}/unlock")]
        Task Unlock(string externalTaskId);

        [Post("/external-task/{externalTaskId}/extendLock")]
        Task ExtendLock(string externalTaskId, [Body] ExternalTaskExtendLock externalTaskExtendLock);

        [Post("/external-task/{externalTaskId}/lock")]
        Task Lock(string externalTaskId, [Body] ExternalTaskLock externalTaskExtendLock);
    }
}
