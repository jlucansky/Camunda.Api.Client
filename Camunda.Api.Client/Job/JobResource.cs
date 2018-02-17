using System;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Job
{
    public class JobResource
    {
        private IJobRestService _api;
        private string _jobId;

        internal JobResource(IJobRestService api, string jobId)
        {
            _api = api;
            _jobId = jobId;
        }

        /// <summary>
        /// Retrieves a single job according to the Job interface in the engine.
        /// </summary>
        public Task<JobInfo> Get() => _api.Get(_jobId);

        /// <summary>
        /// Retrieves the corresponding exception stacktrace to the passed job id.
        /// </summary>
        public async Task<string> GetStacktrace() => await (await _api.GetStacktrace(_jobId)).Content.ReadAsStringAsync();

        /// <summary>
        /// Executes the job. The execution of the job happens synchronously in the same thread.
        /// </summary>
        public Task Execute() => _api.ExecuteJob(_jobId);

        /// <summary>
        /// Updates the due date of a job.
        /// </summary>
        public Task SetDuedate(DateTime duedate) => _api.SetJobDuedate(_jobId, new JobDuedateInfo() { Duedate = duedate });

        /// <summary>
        /// Activate or suspend a given job by id.
        /// </summary>
        public Task UpdateSuspensionState(bool suspended) => _api.UpdateSuspensionStateForId(_jobId, new SuspensionState() { Suspended = suspended });

        /// <summary>
        /// Sets the execution priority of a job.
        /// </summary>
        public Task SetPriority(long priority) => _api.SetJobPriority(_jobId, new PriorityInfo() { Priority = priority });

        /// <summary>
        /// Sets the retries of the job to the given number of retries.
        /// </summary>
        public Task SetRetries(long retries) => _api.SetJobRetries(_jobId, new RetriesInfo() { Retries = retries });

        /// <summary>
        /// Deletes a job.
        /// </summary>
        public Task Delete() => _api.DeleteJob(_jobId);

        public override string ToString() => _jobId;
    }
}
