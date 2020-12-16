namespace Camunda.Api.Client.History
{
    public class HistoricCaseInstanceService
    {
        private IHistoricCaseInstanceRestService _api;

        internal HistoricCaseInstanceService(IHistoricCaseInstanceRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricCaseInstanceQuery, HistoricCaseInstance> Query(
            HistoricCaseInstanceQuery query = null) =>
            new QueryResource<HistoricCaseInstanceQuery, HistoricCaseInstance>(query, _api.GetList, _api.GetListCount);

        /// <param name="caseInstanceId">The id of the historic case instance to be retrieved.</param>
        public HistoricCaseInstanceResource this[string caseInstanceId] => new HistoricCaseInstanceResource(_api, caseInstanceId);
    }
}