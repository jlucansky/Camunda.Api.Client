using Camunda.Api.Client.ProcessInstance;
using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ProcessDefinition
{
    internal interface IProcessDefinitionRestService
    {
        [Get("/process-definition")]
        Task<List<ProcessDefinitionInfo>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/process-definition/count")]
        Task<CountResult> GetListCount(QueryDictionary query);

        [Get("/process-definition/statistics")]
        Task<List<ProcessDefinitionStatisticsResult>> GetProcessInstanceStatistics(bool failedJobs, bool? incidents, string incidentsForType);

        [Delete("/process-definition/{id}")]
        Task Delete(string id, bool cascade, bool skipCustomListeners);

        [Put("/process-definition/{id}/suspended")]
        Task UpdateSuspensionStateById(string id, [Body] ProcessDefinitionSuspensionState state);
        [Put("/process-definition/key/{key}/suspended")]
        Task UpdateSuspensionStateByKey(string key, [Body] ProcessDefinitionSuspensionState state);
        [Put("/process-definition/key/{key}/tenant-id/{tenantId}/suspended")]
        Task UpdateSuspensionStateByKeyAndTenantId(string key, string tenantId, [Body] ProcessDefinitionSuspensionState state);


        [Get("/process-definition/{id}")]
        Task<ProcessDefinitionInfo> GetById(string id);
        [Get("/process-definition/key/{key}")]
        Task<ProcessDefinitionInfo> GetByKey(string key);
        [Get("/process-definition/key/{key}/tenant-id/{tenantId}")]
        Task<ProcessDefinitionInfo> GetByKeyAndTenantId(string key, string tenantId);


        [Get("/process-definition/{id}/xml")]
        Task<ProcessDefinitionDiagram> GetXmlById(string id);
        [Get("/process-definition/key/{key}/xml")]
        Task<ProcessDefinitionDiagram> GetXmlByKey(string key);
        [Get("/process-definition/key/{key}/tenant-id/{tenantId}/xml")]
        Task<ProcessDefinitionDiagram> GetXmlByKeyAndTenantId(string key, string tenantId);


        [Get("/process-definition/{id}/diagram")]
        Task<HttpResponseMessage> GetDiagramById(string id);
        [Get("/process-definition/key/{key}/diagram")]
        Task<HttpResponseMessage> GetDiagramByKey(string key);
        [Get("/process-definition/key/{key}/tenant-id/{tenantId}/diagram")]
        Task<HttpResponseMessage> GetDiagramByKeyAndTenantId(string key, string tenantId);


        [Get("/process-definition/{id}/form-variables")]
        Task<Dictionary<string, VariableValue>> GetFormVariablesById(string id, string variableNames, bool deserializeValues = true);
        [Get("/process-definition/key/{key}/form-variables")]
        Task<Dictionary<string, VariableValue>> GetFormVariablesByKey(string key, string variableNames, bool deserializeValues = true);
        [Get("/process-definition/key/{key}/tenant-id/{tenantId}/form-variables")]
        Task<Dictionary<string, VariableValue>> GetFormVariablesByKeyAndTenantId(string key, string tenantId, string variableNames, bool deserializeValues = true);


        [Get("/process-definition/{id}/startForm")]
        Task<FormInfo> GetStartFormById(string id);
        [Get("/process-definition/key/{key}/startForm")]
        Task<FormInfo> GetStartFormByKey(string key);
        [Get("/process-definition/key/{key}/tenant-id/{tenantId}/startForm")]
        Task<FormInfo> GetStartFormByKeyAndTenantId(string key, string tenantId);


        [Get("/process-definition/{id}/rendered-form")]
        Task<string> GetRenderedFormById(string id);
        [Get("/process-definition/key/{key}/rendered-form")]
        Task<string> GetRenderedFormByKey(string key);
        [Get("/process-definition/key/{key}/tenant-id/{tenantId}/rendered-form")]
        Task<string> GetRenderedFormByKeyAndTenantId(string key, string tenantId);


        [Get("/process-definition/{id}/statistics")]
        Task<List<StatisticsResult>> GetActivityStatisticsById(string id, bool failedJobs, bool? incidents, string incidentsForType);
        [Get("/process-definition/key/{key}/statistics")]
        Task<List<StatisticsResult>> GetActivityStatisticsByKey(string key, bool failedJobs, bool? incidents, string incidentsForType);
        [Get("/process-definition/key/{key}/tenant-id/{tenantId}/statistics")]
        Task<List<StatisticsResult>> GetActivityStatisticsByKeyAndTenantId(string key, string tenantId, bool failedJobs, bool? incidents, string incidentsForType);


        [Post("/process-definition/{id}/submit-form")]
        Task<ProcessInstanceInfo> SubmitStartFormById(string id, [Body] SubmitStartForm parameters);
        [Post("/process-definition/key/{key}/submit-form")]
        Task<ProcessInstanceInfo> SubmitStartFormByKey(string key, [Body] SubmitStartForm parameters);
        [Post("/process-definition/key/{key}/tenant-id/{tenantId}/submit-form")]
        Task<ProcessInstanceInfo> SubmitStartFormByKeyAndTenantId(string key, string tenantId, [Body] SubmitStartForm parameters);


        [Post("/process-definition/{id}/start")]
        Task<ProcessInstanceWithVariables> StartProcessInstanceById(string id, [Body] StartProcessInstance parameters);
        [Post("/process-definition/key/{key}/start")]
        Task<ProcessInstanceWithVariables> StartProcessInstanceByKey(string key, [Body] StartProcessInstance parameters);
        [Post("/process-definition/key/{key}/tenant-id/{tenantId}/start")]
        Task<ProcessInstanceWithVariables> StartProcessInstanceByKeyAndTenantId(string key, string tenantId, [Body] StartProcessInstance parameters);
    }
}
