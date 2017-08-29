using Camunda.Api.Client.Batch;
using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Job
{
    internal interface IJobRestService
    {
        [Get("/job/{jobId}")]
        Task<JobInfo> Get(string jobId);

        [Post("/job")]
        Task<List<JobInfo>> GetList([Body] JobQuery query, int? firstResult, int? maxResults);

        [Post("/job/count")]
        Task<CountResult> GetListCount([Body] JobQuery query);

        [Get("/job/{jobId}/stacktrace")]
        Task<HttpResponseMessage> GetStacktrace(string jobId);

        [Post("/job/{jobId}/execute")]
        Task ExecuteJob(string jobId);

        [Put("/job/{jobId}/duedate")]
        Task SetJobDuedate(string jobId, [Body] JobDuedateInfo duedate);

        [Put("/job/{jobId}/suspended")]
        Task UpdateSuspensionStateForId(string jobId, [Body] SuspensionState state);

        [Put("/job/suspended")]
        Task UpdateSuspensionState([Body] JobSuspensionState state);

        [Put("/job/{jobId}/priority")]
        Task SetJobPriority(string jobId, [Body] PriorityInfo priority);

        [Put("/job/{jobId}/retries")]
        Task SetJobRetries(string jobId, [Body] RetriesInfo retries);

        [Delete("/job/{jobId}")]
        Task DeleteJob(string jobId);

        [Post("/job/retries")]
        Task<BatchInfo> SetJobRetriesAsync([Body] JobRetries retries);
    }
}
