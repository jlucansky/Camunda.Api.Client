namespace Camunda.Api.Client.History
{
    public class HistoricIncidentService
    {
        private IHistoricIncidentRestService _api;

        internal HistoricIncidentService(IHistoricIncidentRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricIncidentQuery, HistoricIncident> Query(HistoricIncidentQuery query = null) =>
            new QueryResource<HistoricIncidentQuery, HistoricIncident>(
                query, 
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));
    }
}
