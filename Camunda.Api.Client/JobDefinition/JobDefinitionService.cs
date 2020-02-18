using System.Threading.Tasks;

namespace Camunda.Api.Client.JobDefinition
{
    public class JobDefinitionService
    {
        private IJobDefinitionRestService _api;

        internal JobDefinitionService(IJobDefinitionRestService api)
        {
            _api = api;
        }

        public QueryResource<JobDefinitionQuery, JobDefinitionInfo> Query(JobDefinitionQuery query = null) =>
            new QueryResource<JobDefinitionQuery, JobDefinitionInfo>(
                query, 
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));

        /// <param name="jobDefinitionId">The id of the job to be retrieved.</param>
        public JobDefinitionResource this[string jobDefinitionId] => new JobDefinitionResource(_api, jobDefinitionId);

        /// <summary>
        /// Activate or suspend jobs with the given job definition id, process definition id, process definition key or process instance id.
        /// </summary>
        public Task UpdateSuspensionState(JobDefinitionSuspensionState state) => _api.UpdateSuspensionState(state);
    }
}
