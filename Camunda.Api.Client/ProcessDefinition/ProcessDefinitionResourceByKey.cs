
using Camunda.Api.Client.ProcessInstance;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionResourceByKey : ProcessDefinitionResource
    {
        private IProcessDefinitionRestService _api;
        private string _processDefinitionKey;

        internal ProcessDefinitionResourceByKey(IProcessDefinitionRestService api, string processDefinitionKey)
        {
            _api = api;
            _processDefinitionKey = processDefinitionKey;
        }

        public override Task<ProcessDefinitionInfo> Get() => _api.GetByKey(_processDefinitionKey);

        public override Task<ProcessDefinitionDiagram> GetXml() => _api.GetXmlByKey(_processDefinitionKey);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramByKey(_processDefinitionKey)).Content;

        public override Task<ProcessInstanceInfo> StartProcessInstance(StartProcessInstance parameters) => _api.StartProcessInstanceByKey(_processDefinitionKey, parameters);

        public override Task<ProcessInstanceInfo> SubmitForm(SubmitStartForm parameters) => _api.SubmitStartFormByKey(_processDefinitionKey, parameters);

        protected override Task<List<StatisticsResult>> GetActivityStatistics(bool includeFailedJobs, bool? includeIncidents, string includeIncidentsForType) =>
            _api.GetActivityStatisticsByKey(_processDefinitionKey, includeFailedJobs, includeIncidents, includeIncidentsForType);

        public override Task<FormInfo> GetStartForm() => _api.GetStartFormByKey(_processDefinitionKey);

        public override Task<string> GetRenderedForm() => _api.GetRenderedFormByKey(_processDefinitionKey);

        public override Task UpdateSuspensionState(ProcessDefinitionSuspensionState state) => _api.UpdateSuspensionStateByKey(_processDefinitionKey, state);

        public override Task<Dictionary<string, VariableValue>> GetFormVariables(params string[] variableNames) => _api.GetFormVariablesByKey(_processDefinitionKey, variableNames.Join());

        public override string ToString() => _processDefinitionKey;
    }
}
