using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricCaseDefinitionResource
    {
        private IHistoricCaseDefinitionRestService _api;
        private string _caseDefinitionId;

        internal HistoricCaseDefinitionResource(IHistoricCaseDefinitionRestService api, string caseDefinitionId)
        {
            _api = api;
            _caseDefinitionId = caseDefinitionId;
        }

        public Task<List<HistoricCaseDefinitionStatisticsResult>> GetActivityStatistics() => _api.GetActivityStatistics(_caseDefinitionId);
    }
}