using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.DecisionDefinition
{
    internal interface IDecisionDefinitionRestService
    {
        [Get("/decision-definition")]
        Task<List<DecisionDefinitionInfo>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/decision-definition/count")]
        Task<CountResult> GetListCount(QueryDictionary query);


        [Get("/decision-definition/{id}")]
        Task<DecisionDefinitionInfo> GetById(string id);
        [Get("/decision-definition/key/{key}")]
        Task<DecisionDefinitionInfo> GetByKey(string key);
        [Get("/decision-definition/key/{key}/tenant-id/{tenantId}")]
        Task<DecisionDefinitionInfo> GetByKeyAndTenantId(string key, string tenantId);


        [Get("/decision-definition/{id}/xml")]
        Task<DecisionDefinitionDiagram> GetXmlById(string id);
        [Get("/decision-definition/key/{key}/xml")]
        Task<DecisionDefinitionDiagram> GetXmlByKey(string key);
        [Get("/decision-definition/key/{key}/tenant-id/{tenantId}/xml")]
        Task<DecisionDefinitionDiagram> GetXmlByKeyAndTenantId(string key, string tenantId);


        [Get("/decision-definition/{id}/diagram")]
        Task<HttpResponseMessage> GetDiagramById(string id);
        [Get("/decision-definition/key/{key}/diagram")]
        Task<HttpResponseMessage> GetDiagramByKey(string key);
        [Get("/decision-definition/key/{key}/tenant-id/{tenantId}/diagram")]
        Task<HttpResponseMessage> GetDiagramByKeyAndTenantId(string key, string tenantId);


        [Post("/decision-definition/{id}/evaluate")]
        Task<List<Dictionary<string, VariableValue>>> EvaluateById(string id, [Body] EvaluateDecision parameters);
        [Post("/decision-definition/key/{key}/evaluate")]
        Task<List<Dictionary<string, VariableValue>>> EvaluateByKey(string key, [Body] EvaluateDecision parameters);
        [Post("/decision-definition/key/{key}/tenant-id/{tenantId}/evaluate")]
        Task<List<Dictionary<string, VariableValue>>> EvaluateByKeyAndTenantId(string key, string tenantId, [Body] EvaluateDecision parameters);
    }
}
