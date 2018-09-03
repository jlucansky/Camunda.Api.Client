using Refit;
using System.Threading.Tasks;

namespace Camunda.Api.Client.CaseExecution
{
    internal interface ICaseExecutionRestService
    {
        [Post("/case-execution/{id}/manual-start")]
        Task StartExecution(string id, [Body]CaseExecutionStart start);

        [Post("/case-execution/{id}/complete")]
        Task CompleteExecution(string id, [Body]CaseExecutionComplete complete);

        [Post("/case-execution/{id}/disable")]
        Task DisableExecution(string id, [Body]CaseExecutionDisable disable);

        [Post("/case-execution/{id}/reenable")]
        Task ReEnableExecution(string id, [Body]CaseExecutionReEnable reenable);

        [Post("/case-execution/{id}/terminate")]
        Task TerminateExecution(string id, [Body]CaseExecutionTerminate terminate);
    }
}