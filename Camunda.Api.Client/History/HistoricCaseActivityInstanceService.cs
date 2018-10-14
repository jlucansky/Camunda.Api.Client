namespace Camunda.Api.Client.History
{
    public class HistoricCaseActivityInstanceService
    {
        private IHistoricCaseActivityInstanceRestService _api;

        internal HistoricCaseActivityInstanceService(IHistoricCaseActivityInstanceRestService api)
        {
            _api = api;
        }

        public HistoricCaseActivityInstanceQueryResource Query(HistoricCaseActivityInstanceQuery query = null) =>
            new HistoricCaseActivityInstanceQueryResource(_api, query);

        /// <param name="caseActivityInstanceId">The id of the historic case activity instance to be retrieved.</param>
        public HistoricCaseActivityInstanceResource this[string caseActivityInstanceId] => new HistoricCaseActivityInstanceResource(_api, caseActivityInstanceId);
    }
}