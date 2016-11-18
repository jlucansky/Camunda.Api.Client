
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ExternalTask
{
    public class ExternalTaskService
    {
        private IExternalTaskRestService _api;

        internal ExternalTaskService(IExternalTaskRestService api) { _api = api; }

        public QueryResource<ExternalTaskQuery, ExternalTaskInfo> Query(ExternalTaskQuery query = null) =>
            new QueryResource<ExternalTaskQuery, ExternalTaskInfo>(_api, query);

        /// <param name="externalTaskId">The id of the external task to be retrieved.</param>
        public ExternalTaskResource this[string externalTaskId] => new ExternalTaskResource(_api, externalTaskId);
        
        /// <summary>
        /// Fetches and locks a specific number of external tasks for execution by a worker. Query can be restricted to specific task topics and for each task topic an individual lock time can be provided.
        /// </summary>
        public Task<List<LockedExternalTask>> FetchAndLock(FetchExternalTasks fetching) => _api.FetchAndLock(fetching);
    }
}
