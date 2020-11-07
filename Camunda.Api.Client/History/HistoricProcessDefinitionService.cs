using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricProcessDefinitionService
    {
        private IHistoricProcessDefinitionRestService _api;

        internal HistoricProcessDefinitionService(IHistoricProcessDefinitionRestService api)
        {
            _api = api;
        }

        /// <summary>
        /// Retrieves historic statistics of a given process definition, grouped by activities. These statistics include the number of running activity instances and, optionally, the number of canceled activity instances, finished activity instances and activity instances which completed a scope (i.e., in BPMN 2.0 manner: a scope is completed by an activity instance when the activity instance consumed a token but did not emit a new token).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="historicActivityStatistics"></param>
        /// <returns></returns>
        public Task<List<HistoricActivityStatisticsResult>> GetHistoricActivityStatistics(string id, HistoricActivityStatistics historicActivityStatistics) 
            => _api.GetHistoricActivityStatistics(id, historicActivityStatistics);

        /// <summary>
        /// Retrieves a report about a process definition and finished process instances relevant to history cleanup (see History cleanup) so that you can tune the history time to live. These reports include the count of the finished historic process instances, cleanable process instances and basic process definition data - id, key, name and version. The size of the result set can be retrieved by using the Get Cleanable Process Instance Report Count method.
        /// </summary>
        /// <param name="cleanableProcessInstanceReport"></param>
        /// <returns></returns>
        public Task<List<CleanableProcessInstanceReportResult>> GetCleanableProcessInstanceReport(CleanableProcessInstanceReport cleanableProcessInstanceReport) 
            => _api.GetCleanableProcessInstanceReport(cleanableProcessInstanceReport);

        /// <summary>
        /// Queries for the number of report results about a process definition and finished process instances relevant to history cleanup (see History cleanup). Takes the same parameters as the Get Cleanable Process Instance Report method.
        /// </summary>
        /// <param name="cleanableProcessInstanceReportCount"></param>
        /// <returns></returns>
        public async Task<int> GetCleanableProcessInstanceReportCount(CleanableProcessInstanceReportCount cleanableProcessInstanceReportCount) 
            => (await _api.GetCleanableProcessInstanceReportCount(cleanableProcessInstanceReportCount)).Count;
    }
}
