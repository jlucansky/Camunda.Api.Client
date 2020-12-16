using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricUserTaskService
    {
        private IHistoricUserTaskRestService _api;

        internal HistoricUserTaskService(IHistoricUserTaskRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricTaskQuery, HistoricTask> Query(HistoricTaskQuery query = null) =>
            new QueryResource<HistoricTaskQuery, HistoricTask>(query, _api.GetList, _api.GetListCount);

        /// <summary>
        /// Retrieves a report of completed tasks. When the report type is set to count, the report contains a list of completed task counts where an entry contains the task name, the definition key of the task, the process definition id, the process definition key, the process definition name and the count of how many tasks were completed for the specified key in a given period. When the report type is set to duration, the report contains a minimum, maximum and average duration value of all completed task instances in a given period.
        /// </summary>
        /// <param name="historicTaskReport"></param>
        /// <returns></returns>
        public Task<List<DurationReportResult>> GetDurationReport(HistoricTaskDurationReport historicTaskReport) => _api.GetDurationReport(historicTaskReport);

        /// <summary>
        /// Retrieves a report of completed tasks. When the report type is set to count, the report contains a list of completed task counts where an entry contains the task name, the definition key of the task, the process definition id, the process definition key, the process definition name and the count of how many tasks were completed for the specified key in a given period. When the report type is set to duration, the report contains a minimum, maximum and average duration value of all completed task instances in a given period.
        /// </summary>
        /// <param name="historicTaskReport"></param>
        /// <returns></returns>
        public Task<List<CountReportResult>> GetCountReport(HistoricTaskCountReport historicTaskReport) => _api.GetCountReport(historicTaskReport);
    }
}
