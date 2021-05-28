using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricDecisionInstanceService
    {
        private IHistoricDecisionInstanceRestService _api;

        internal HistoricDecisionInstanceService(IHistoricDecisionInstanceRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricDecisionInstanceQuery, HistoricDecisionInstance> Query(
            HistoricDecisionInstanceQuery query = null) =>
            new QueryResource<HistoricDecisionInstanceQuery, HistoricDecisionInstance>(
                query,
                (q, f, m) => _api.GetList(q, f, m), 
                q => _api.GetListCount(q));

        /// <param name="decisionInstanceId">The id of the historic decision instance to be retrieved.</param>
        public HistoricDecisionInstanceResource this[string decisionInstanceId] => new HistoricDecisionInstanceResource(_api, decisionInstanceId);

        /// <summary>
        /// Delete multiple historic decision instances asynchronously (batch). 
        /// At least historicDecisionInstanceIds or historicDecisionInstanceQuery has to be provided.
        /// If both are provided then all instances matching query criterion and instances from the list will be deleted.
        /// </summary>
        /// <param name="historicDeleteDecisionInstance"></param>
        /// <returns></returns>
        public Task<HistoricDeleteDecisionInstanceResult> Delete(HistoricDeleteDecisionInstance historicDeleteDecisionInstance) => _api.Delete(historicDeleteDecisionInstance);

        /// <summary>
        /// Sets the removal time to multiple historic decision instances asynchronously (batch).
        /// At least historicDecisionInstanceIds or historicDecisionInstanceQuery has to be provided. 
        /// If both are provided, all instances matching query criterion and instances from the list will be updated with a removal time.
        /// </summary>
        /// <param name="historicSetRemovalTimeDecisionInstance"></param>
        /// <returns></returns>
        public Task<HistoricDeleteDecisionInstanceResult> SetRemovalTime(HistoricSetRemovalTimeDecisionInstance historicSetRemovalTimeDecisionInstance) => _api.SetRemovalTime(historicSetRemovalTimeDecisionInstance);
    }
}