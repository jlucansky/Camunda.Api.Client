using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.DecisionDefinition
{
    public class DecisionDefinitionResourceByKey : DecisionDefinitionResource
    {
        private IDecisionDefinitionRestService _api;
        private string _decisionDefinitionKey;

        internal DecisionDefinitionResourceByKey(IDecisionDefinitionRestService api, string decisionDefinitionKey)
        {
            _api = api;
            _decisionDefinitionKey = decisionDefinitionKey;
        }

        public override Task<DecisionDefinitionInfo> Get() => _api.GetByKey(_decisionDefinitionKey);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramByKey(_decisionDefinitionKey)).Content;

        public override Task<DecisionDefinitionDiagram> GetXml() => _api.GetXmlByKey(_decisionDefinitionKey);

        public override Task<List<Dictionary<string, VariableValue>>> Evaluate(EvaluateDecision parameters) => _api.EvaluateByKey(_decisionDefinitionKey, parameters);
    }
}