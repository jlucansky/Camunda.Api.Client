namespace Camunda.Api.Client.History
{
    public class HistoricCaseDefinitionService
    {
        private IHistoricCaseDefinitionRestService _api;

        internal HistoricCaseDefinitionService(IHistoricCaseDefinitionRestService api)
        {
            _api = api;
        }

        public HistoricCaseDefinitionResource this[string caseDefinitionId] => new HistoricCaseDefinitionResource(_api, caseDefinitionId);
    }
}