namespace Camunda.Api.Client.CaseDefinition
{
    public class CaseDefinitionService
    {
        private ICaseDefinitionRestService _api;

        internal CaseDefinitionService(ICaseDefinitionRestService api) { _api = api; }

        public CaseDefinitionResource this[string caseDefinitionId] => new CaseDefinitionResourceById(_api, caseDefinitionId);

        public CaseDefinitionResource ByKey(string caseDefinitionKey) => new CaseDefinitionResourceByKey(_api, caseDefinitionKey);

        public CaseDefinitionResource ByKey(string caseDefinitionKey, string tenantId) => new CaseDefinitionResourceByKeyAndTenantId(_api, caseDefinitionKey, tenantId);

        public QueryResource<CaseDefinitionQuery, CaseDefinitionInfo> Query(CaseDefinitionQuery query = null) =>
            new QueryResource<CaseDefinitionQuery, CaseDefinitionInfo>(_api, query);
    }
}
