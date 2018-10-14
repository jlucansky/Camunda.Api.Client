using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.DecisionDefinition
{
    public class DecisionDefinitionResourceById : DecisionDefinitionResource
    {
        private IDecisionDefinitionRestService _api;
        private string _decisionDefinitionId;

        internal DecisionDefinitionResourceById(IDecisionDefinitionRestService api, string decisionDefinitionId)
        {
            _api = api;
            _decisionDefinitionId = decisionDefinitionId;
        }

        public override Task<DecisionDefinitionInfo> Get() => _api.GetById(_decisionDefinitionId);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramById(_decisionDefinitionId)).Content;

        public override Task<DecisionDefinitionDiagram> GetXml() => _api.GetXmlById(_decisionDefinitionId);

        public override Task<List<Dictionary<string, VariableValue>>> Evaluate(EvaluateDecision parameters) => _api.EvaluateById(_decisionDefinitionId, parameters);
    }
}