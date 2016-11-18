using System.Threading.Tasks;

namespace Camunda.Api.Client.Job
{
    public class JobService
    {
        private IJobRestService _api;

        internal JobService(IJobRestService api)
        {
            _api = api;
        }

        public QueryResource<JobQuery, JobInfo> Query(JobQuery query = null) =>
            new QueryResource<JobQuery, JobInfo>(_api, query);

        /// <param name="jobId">The id of the job to be retrieved.</param>
        public JobResource this[string jobId] => new JobResource(_api, jobId);

        /// <summary>
        /// Activate or suspend jobs with the given job definition id, process definition id, process definition key or process instance id.
        /// </summary>
        public Task UpdateSuspensionState(JobSuspensionState state) => _api.UpdateSuspensionState(state);
    }
}
