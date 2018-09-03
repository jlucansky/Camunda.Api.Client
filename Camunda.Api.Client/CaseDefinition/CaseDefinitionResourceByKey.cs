using Camunda.Api.Client.CaseInstance;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.CaseDefinition
{
    public class CaseDefinitionResourceByKey : CaseDefinitionResource
    {
        private ICaseDefinitionRestService _api;
        private string _caseDefinitionKey;

        internal CaseDefinitionResourceByKey(ICaseDefinitionRestService api, string caseDefinitionKey)
        {
            _api = api;
            _caseDefinitionKey = caseDefinitionKey;
        }

        public override Task<CaseDefinitionInfo> Get() => _api.GetByKey(_caseDefinitionKey);

        public override Task<CaseDefinitionDiagram> GetXml() => _api.GetXmlByKey(_caseDefinitionKey);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramByKey(_caseDefinitionKey)).Content;

        public override Task<CaseInstanceInfo> CreateCaseInstance(CreateCaseInstance parameters) => _api.CreateCaseInstanceByKey(_caseDefinitionKey, parameters);

        public override string ToString() => _caseDefinitionKey;
    }
}