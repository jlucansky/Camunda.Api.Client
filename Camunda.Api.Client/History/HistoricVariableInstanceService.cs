namespace Camunda.Api.Client.History
{
    public class HistoricVariableInstanceService
    {
        private IHistoricVariableInstanceRestService _api;

        internal HistoricVariableInstanceService(IHistoricVariableInstanceRestService api)
        {
            _api = api;
        }

        public HistoricVariableInstanceQueryResource Query(HistoricVariableInstanceQuery query = null) =>
            new HistoricVariableInstanceQueryResource(_api, query ?? new HistoricVariableInstanceQuery());

        /// <param name="variableId">The id of the variable instance.</param>
        public HistoricVariableInstanceResource this[string variableId] => new HistoricVariableInstanceResource(_api, variableId);
    }
}
