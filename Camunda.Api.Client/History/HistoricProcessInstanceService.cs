using Camunda.Api.Client.Batch;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricProcessInstanceService
    {
        private IHistoricProcessInstanceRestService _api;

        internal HistoricProcessInstanceService(IHistoricProcessInstanceRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricProcessInstanceQuery, HistoricProcessInstance> Query(
            HistoricProcessInstanceQuery query = null) =>
            new QueryResource<HistoricProcessInstanceQuery, HistoricProcessInstance>(query, _api.GetList, _api.GetListCount);

        /// <param name="processInstanceId">The id of the historic process instance to be retrieved.</param>
        public HistoricProcessInstanceResource this[string processInstanceId] => new HistoricProcessInstanceResource(_api, processInstanceId);

        /// <summary>
        /// Delete multiple historic process instances asynchronously (batch).
        /// At least <see cref="DeleteHistoricProcessInstances.HistoricProcessInstanceIds"/> or <see cref="DeleteHistoricProcessInstances.HistoricProcessInstanceQuery"/> has to be provided.
        /// If both are provided then all instances matching query criterion and instances from the list will be deleted.
        /// </summary>
        public Task<BatchInfo> Delete(DeleteHistoricProcessInstances deleteHistoricProcessInstances) => _api.DeleteAsync(deleteHistoricProcessInstances);

        /// <summary>
        /// Retrieves a report about the duration of completed process instances, grouped by a period. These reports include the maximum, minimum and average duration of all completed process instances which were started in a given period.
        /// </summary>
        /// <remarks>This only includes historic data.</remarks>
        public Task<List<DurationReportResult>> GetDurationReport(HistoricProcessInstanceReport historicProcessInstanceReport) => _api.GetDurationReport(historicProcessInstanceReport);
    }
}
