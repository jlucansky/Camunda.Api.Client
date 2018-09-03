using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.DecisionDefinition
{
    public class DecisionDefinitionResourceByKeyAndTenantId : DecisionDefinitionResource
    {
        private IDecisionDefinitionRestService _api;
        private string _decisionDefinitionKey, _tenantId;

        internal DecisionDefinitionResourceByKeyAndTenantId(IDecisionDefinitionRestService api, string decisionDefinitionKey, string tenantId)
        {
            _api = api;
            _decisionDefinitionKey = decisionDefinitionKey;
            _tenantId = tenantId;
        }

        public override Task<DecisionDefinitionInfo> Get() => _api.GetByKeyAndTenantId(_decisionDefinitionKey, _tenantId);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramByKeyAndTenantId(_decisionDefinitionKey, _tenantId)).Content;

        public override Task<DecisionDefinitionDiagram> GetXml() => _api.GetXmlByKeyAndTenantId(_decisionDefinitionKey, _tenantId);

        public override Task<List<Dictionary<string, VariableValue>>> Evaluate(EvaluateDecision parameters) => _api.EvaluateByKeyAndTenantId(_decisionDefinitionKey, _tenantId, parameters);
    }
}