using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionService
    {
        private IProcessDefinitionRestService _api;

        internal ProcessDefinitionService(IProcessDefinitionRestService api) { _api = api; }

        public ProcessDefinitionResource this[string processDefinitionId] => new ProcessDefinitionResourceById(_api, processDefinitionId);

        public ProcessDefinitionResource ByKey(string processDefinitionKey) => new ProcessDefinitionResourceByKey(_api, processDefinitionKey);

        public ProcessDefinitionResource ByKey(string processDefinitionKey, string tenantId) => new ProcessDefinitionResourceByKeyAndTenantId(_api, processDefinitionKey, tenantId);

        public QueryResource<ProcessDefinitionQuery, ProcessDefinitionInfo> Query(ProcessDefinitionQuery query = null) => 
            new QueryResource<ProcessDefinitionQuery, ProcessDefinitionInfo>(_api, query);

        /// <summary>
        /// Retrieves runtime statistics of the process engine grouped by process definitions. These statistics include the number of running process instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        /// <param name="includeIncidents">If this property has been set to true the result will include the corresponding number of incidents for each occurred incident type. If it is set to false, the incidents will not be included in the result.</param>
        /// <remarks>This does not include historic data.</remarks>
        public Task<List<ProcessDefinitionStatisticsResult>> GetStatistics(bool includeFailedJobs, bool includeIncidents) =>
            _api.GetProcessInstanceStatistics(includeFailedJobs, includeIncidents, null);

        /// <summary>
        /// Retrieves runtime statistics of the process engine grouped by process definitions. These statistics include the number of running process instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        /// <param name="includeIncidentsForType">If this property has been set with any incident type (i.e. a string value) the result will only include the number of incidents for the assigned incident type.</param>
        /// <remarks>This does not include historic data.</remarks>
        public Task<List<ProcessDefinitionStatisticsResult>> GetStatistics(bool includeFailedJobs, string includeIncidentsForType) =>
            _api.GetProcessInstanceStatistics(includeFailedJobs, null, includeIncidentsForType);

        /// <summary>
        /// Retrieves runtime statistics of the process engine grouped by process definitions. These statistics include the number of running process instances, optionally the number of failed jobs and also optionally the number of incidents either grouped by incident types or for a specific incident type.
        /// </summary>
        /// <param name="includeFailedJobs">Whether to include the number of failed jobs in the result or not.</param>
        /// <remarks>This does not include historic data.</remarks>
        public Task<List<ProcessDefinitionStatisticsResult>> GetStatistics(bool includeFailedJobs) => GetStatistics(includeFailedJobs, false);

    }
}
