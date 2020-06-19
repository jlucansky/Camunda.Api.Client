using Camunda.Api.Client.Batch;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ProcessInstance
{
    public class ProcessInstanceService
    {
        private IProcessInstanceRestService _api;

        internal ProcessInstanceService(IProcessInstanceRestService api) { _api = api; }

        public QueryResource<ProcessInstanceQuery, ProcessInstanceInfo> Query(ProcessInstanceQuery query = null) =>
            new QueryResource<ProcessInstanceQuery, ProcessInstanceInfo>(
                query, 
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));

        /// <param name="processInstanceId">The id of the process instance to be retrieved.</param>
        public ProcessInstanceResource this[string processInstanceId] => new ProcessInstanceResource(_api, processInstanceId);

        /// <summary>
        /// Activate or suspend process instances with the given process definition id or process definition key.
        /// </summary>
        public Task UpdateSuspensionState(ProcessInstanceSuspensionState state) => _api.UpdateSuspensionState(state);

        /// <summary>
        /// Deletes multiple process instances asynchronously (batch).
        /// </summary>
        public Task<BatchInfo> Delete(DeleteProcessInstances deleteProcessInstances) => _api.DeleteProcessInstanceAsync(deleteProcessInstances);

        /// <summary>
        /// Create a batch to set retries of jobs associated with given processes asynchronously.
        /// </summary>
        public Task<BatchInfo> SetRetriesByProcess(JobRetriesByProcess setJobRetries) => _api.SetRetriesByProcess(setJobRetries);
    }
}
