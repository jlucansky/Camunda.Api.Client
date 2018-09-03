namespace Camunda.Api.Client.CaseExecution
{
    public class CaseExecutionService
    {
        private ICaseExecutionRestService _api;

        internal CaseExecutionService(ICaseExecutionRestService api)
        {
            _api = api;
        }

        public CaseExecutionResource this[string caseExecutionId] => new CaseExecutionResource(_api, caseExecutionId);
    }
}