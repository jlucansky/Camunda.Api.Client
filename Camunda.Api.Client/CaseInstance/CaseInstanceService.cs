namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceService
    {
        private ICaseInstanceRestService _api;

        internal CaseInstanceService(ICaseInstanceRestService api)
        {
            _api = api;
        }

        public QueryResource<CaseInstanceQuery, CaseInstanceInfo> Query(CaseInstanceQuery query = null) =>
            new QueryResource<CaseInstanceQuery, CaseInstanceInfo>(query, _api.GetList, _api.GetListCount);

        /// <param name="caseInstanceId">Id of specific case instance</param>
        public CaseInstanceResource this[string caseInstanceId] => new CaseInstanceResource(_api, caseInstanceId);
    }
}
