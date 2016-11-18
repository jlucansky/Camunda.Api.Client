using System.Threading.Tasks;

namespace Camunda.Api.Client.JobDefinition
{
    public class JobDefinitionResource
    {
        private string _jobDefinitionId;
        private IJobDefinitionRestService _api;

        internal JobDefinitionResource(IJobDefinitionRestService api, string jobDefinitionId)
        {
            _api = api;
            _jobDefinitionId = jobDefinitionId;
        }

        /// <summary>
        /// Retrieves a single job definition according to the JobDefinition interface in the engine.
        /// </summary>
        public Task<JobDefinitionInfo> Get() => _api.Get(_jobDefinitionId);

        /// <summary>
        /// Activate or suspend a given job definition by id.
        /// </summary>
        public Task UpdateSuspensionState(bool suspended) => _api.UpdateSuspensionState(_jobDefinitionId, new SuspensionState() { Suspended = suspended });

        /// <summary>
        /// Set the number of retries of all failed jobs associated with the given job definition id.
        /// </summary>
        public Task SetRetries(long retries) => _api.SetJobRetries(_jobDefinitionId, new RetriesInfo() { Retries = retries });

        /// <summary>
        /// Set an overriding execution priority for jobs with the given definition id. 
        /// Optionally, the priorities of all the definition’s existing jobs are updated accordingly.
        /// The priority can be reset by setting it to null, meaning that a new job’s priority will not be determined based on its definition’s priority any longer. 
        /// </summary>
        /// <param name="priority"></param>
        /// <returns></returns>
        public Task SetPriority(JobDefinitionPriority priority) => _api.SetJobPriority(_jobDefinitionId, priority);

        public override string ToString() => _jobDefinitionId;
    }
}