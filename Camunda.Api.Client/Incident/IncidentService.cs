namespace Camunda.Api.Client.Incident
{
    public class IncidentService
    {
        private IIncidentRestService _api;

        internal IncidentService(IIncidentRestService api)
        {
            _api = api;
        }

        public QueryResource<IncidentQuery, IncidentInfo> Query(IncidentQuery query = null) =>
            new QueryResource<IncidentQuery, IncidentInfo>(
                query, 
                (q, f, m) => _api.GetList(q, f, m),
                q => _api.GetListCount(q));
    }
}
