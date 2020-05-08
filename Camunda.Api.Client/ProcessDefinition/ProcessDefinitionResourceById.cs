
using Camunda.Api.Client.ProcessInstance;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionResourceById : ProcessDefinitionResource
    {
        private IProcessDefinitionRestService _api;
        private string _processDefinitionId;

        internal ProcessDefinitionResourceById(IProcessDefinitionRestService api, string processDefinitionId)
        {
            _api = api;
            _processDefinitionId = processDefinitionId;
        }

        public override Task<ProcessDefinitionInfo> Get() => _api.GetById(_processDefinitionId);

        public override Task Delete(bool cascade, bool skipCustomListeners, bool skipIoMappings = true) => _api.Delete(_processDefinitionId, cascade, skipCustomListeners, skipIoMappings);

        public override Task<ProcessDefinitionDiagram> GetXml() => _api.GetXmlById(_processDefinitionId);

        public override async Task<HttpContent> GetDiagram() => (await _api.GetDiagramById(_processDefinitionId)).Content;

        public override Task<ProcessInstanceWithVariables> StartProcessInstance(StartProcessInstance parameters) => _api.StartProcessInstanceById(_processDefinitionId, parameters);

        public override Task<ProcessInstanceInfo> SubmitForm(SubmitStartForm parameters) => _api.SubmitStartFormById(_processDefinitionId, parameters);

        protected override Task<List<StatisticsResult>> GetActivityStatistics(bool includeFailedJobs, bool? includeIncidents, string includeIncidentsForType) => 
            _api.GetActivityStatisticsById(_processDefinitionId, includeFailedJobs, includeIncidents, includeIncidentsForType);

        public override Task<FormInfo> GetStartForm() => _api.GetStartFormById(_processDefinitionId);

        public override Task<string> GetRenderedForm() => _api.GetRenderedFormById(_processDefinitionId);

        public override Task UpdateSuspensionState(ProcessDefinitionSuspensionState state) => _api.UpdateSuspensionStateById(_processDefinitionId, state);

        public override Task<Dictionary<string, VariableValue>> GetFormVariables(params string[] variableNames) => _api.GetFormVariablesById(_processDefinitionId, variableNames.Join());

        public override Task<Dictionary<string, VariableValue>> GetFormVariables(string[] variableNames, bool deserializeValues = true) => _api.GetFormVariablesById(_processDefinitionId, variableNames.Join(), deserializeValues);

        public override string ToString() => _processDefinitionId;
    }
}
