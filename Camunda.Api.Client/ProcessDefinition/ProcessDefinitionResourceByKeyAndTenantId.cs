
using Camunda.Api.Client.ProcessInstance;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionResourceByKeyAndTenantId : ProcessDefinitionResource
    {
        private IProcessDefinitionRestService _api;
        private string _processDefinitionKey, _tenantId;

        internal ProcessDefinitionResourceByKeyAndTenantId(IProcessDefinitionRestService api, string processDefinitionKey, string tenantId)
        {
            _api = api;
            _processDefinitionKey = processDefinitionKey;
            _tenantId = tenantId;
        }

        public override Task<ProcessDefinitionInfo> Get() => _api.GetByKeyAndTenantId(_processDefinitionKey, _tenantId);

        public override Task<ProcessDefinitionDiagram> GetXml() => _api.GetXmlByKeyAndTenantId(_processDefinitionKey, _tenantId);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramByKeyAndTenantId(_processDefinitionKey, _tenantId)).Content;

        public override Task<ProcessInstanceInfo> StartProcessInstance(StartProcessInstance parameters) => _api.StartProcessInstanceByKeyAndTenantId(_processDefinitionKey, _tenantId, parameters);

        public override Task<ProcessInstanceInfo> SubmitForm(SubmitStartForm parameters) => _api.SubmitStartFormByKeyAndTenantId(_processDefinitionKey, _tenantId, parameters);

        protected override Task<List<StatisticsResult>> GetActivityStatistics(bool includeFailedJobs, bool? includeIncidents, string includeIncidentsForType) =>
            _api.GetActivityStatisticsByKeyAndTenantId(_processDefinitionKey, _tenantId, includeFailedJobs, includeIncidents, includeIncidentsForType);

        public override Task<FormInfo> GetStartForm() => _api.GetStartFormByKeyAndTenantId(_processDefinitionKey, _tenantId);

        public override Task<string> GetRenderedForm() => _api.GetRenderedFormByKeyAndTenantId(_processDefinitionKey, _tenantId);

        public override Task UpdateSuspensionState(ProcessDefinitionSuspensionState state) => _api.UpdateSuspensionStateByKeyAndTenantId(_processDefinitionKey, _tenantId, state);

        public override Task<Dictionary<string, VariableValue>> GetFormVariables(params string[] variableNames) => _api.GetFormVariablesByKeyAndTenantId(_processDefinitionKey, _tenantId, variableNames.Join());

        public override string ToString() => _processDefinitionKey;
    }
}
