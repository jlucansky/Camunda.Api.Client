using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricDecisionInstanceResource
    {
        private IHistoricDecisionInstanceRestService _api;
        private string _decisionInstanceId;

        internal HistoricDecisionInstanceResource(IHistoricDecisionInstanceRestService api, string decisionInstanceId)
        {
            _api = api;
            _decisionInstanceId = decisionInstanceId;
        }

        /// <summary>
        /// Retrieves a single historic decision instance according to the HistoricDecisionInstance interface in the engine.
        /// </summary>
        public Task<HistoricDecisionInstance> Get() => _api.Get(_decisionInstanceId);
    }
}