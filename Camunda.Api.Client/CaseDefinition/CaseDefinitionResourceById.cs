using Camunda.Api.Client.CaseInstance;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.CaseDefinition
{
    public class CaseDefinitionResourceById : CaseDefinitionResource
    {
        private ICaseDefinitionRestService _api;
        private string _caseDefinitionId;

        internal CaseDefinitionResourceById(ICaseDefinitionRestService api, string caseDefinitionId)
        {
            _api = api;
            _caseDefinitionId = caseDefinitionId;
        }

        public override Task<CaseDefinitionInfo> Get() => _api.GetById(_caseDefinitionId);

        public override Task<CaseDefinitionDiagram> GetXml() => _api.GetXmlById(_caseDefinitionId);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramById(_caseDefinitionId)).Content;

        public override Task<CaseInstanceInfo> CreateCaseInstance(CreateCaseInstance parameters) => _api.CreateCaseInstanceById(_caseDefinitionId, parameters);

        public override string ToString() => _caseDefinitionId;
    }
}