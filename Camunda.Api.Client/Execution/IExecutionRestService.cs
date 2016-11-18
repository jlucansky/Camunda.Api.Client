using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Execution
{
    internal interface IExecutionRestService
    {
        [Post("/execution")]
        Task<List<ExecutionInfo>> GetList([Body] ExecutionQuery query, int? firstResult, int? maxResults);

        [Post("/execution/count")]
        Task<CountResult> GetListCount([Body] ExecutionQuery query);

        [Get("/execution/{id}")]
        Task<ExecutionInfo> Get(string id);

        [Get("/execution/{id}/messageSubscriptions/{messageName}")]
        Task<EventSubscription> GetMessageEventSubscription(string id, string messageName);

        [Post("/execution/{id}/messageSubscriptions/{messageName}/trigger")]
        Task TriggerMessageEventSubscription(string id, string messageName, [Body] ExecutionTrigger trigger);

        [Post("/execution/{id}/signal")]
        Task TriggerExecution(string id, [Body] ExecutionTrigger trigger);

        #region Local Variables

        [Delete("/execution/{id}/localVariables/{varName}")]
        Task DeleteLocalVariable(string id, string varName);

        [Get("/execution/{id}/localVariables/{varName}")]
        Task<VariableValue> GetLocalVariable(string id, string varName, bool deserializeValue = true);

        [Get("/execution/{id}/localVariables")]
        Task<Dictionary<string, VariableValue>> GetLocalVariables(string id, bool deserializeValues = true);

        [Get("/execution/{id}/localVariables/{varName}/data")]
        Task<HttpResponseMessage> GetBinaryLocalVariable(string id, string varName);

        [Post("/execution/{id}/localVariables/{varName}/data"), Multipart]
        Task SetBinaryLocalVariable(string id, string varName, BinaryDataContent data, ValueTypeContent valueType);

        [Post("/execution/{id}/localVariables")]
        Task ModifyLocalVariables(string id, PatchVariables patch);

        [Put("/execution/{id}/localVariables/{varName}")]
        Task PutLocalVariable(string id, string varName, [Body] VariableValue variable);

        #endregion

    }
}
