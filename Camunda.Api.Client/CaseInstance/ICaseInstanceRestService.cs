#region Usings

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;

#endregion

namespace Camunda.Api.Client.CaseInstance
{
    internal interface ICaseInstanceRestService
    {
        [Get("/case-instance/{id}/variables")]
        Task<Dictionary<string, VariableValue>> GetVariables(string id, bool? deserializeValues);

        [Get("/case-instance/{id}/variables/{varName}")]
        Task<VariableValue> GetVariableValue(string id, string varName, bool? deserializeValue);

        // TODO: check if HttpWebResponse is indeed the correct return type
        [Get("/case-instance/{id}/variables/{varName}/data")]
        Task<HttpResponseMessage> GetVariableValueBinary(string id, string varName);

        [Post("/case-instance/{id}/variables")]
        Task ModifyVariables(string id, [Body] CaseInstanceModifications modifications);

        [Put("/case-instance/{id}/variables/{varName}")]
        Task UpdateVariable(string id, string varName, [Body] VariableValue value);

        [Post("/case-instance/{id}/variables/{varName}/data")]
        Task SetVariableBinary(string id, string varName, [Body] CaseInstanceBinaryVariableValue value);

        [Delete("/case-instance/{id}/variables/{varName}")]
        Task DeleteVariable(string id, string varName);

        [Get("/case-instance/{id}")]
        Task<CaseInstanceInfo> Get(string id);

        [Post("/case-instance")]
        Task<List<CaseInstanceInfo>> GetList([Body] CaseInstanceQuery query, int? firstResult, int? maxResults);

        [Post("/case-instance/count")]
        Task<CountResult> GetListCount([Body] CaseInstanceQuery query);

        [Post("/case-instance/{id}/complete")]
        Task Complete(string id, [Body] ChangeCaseInstanceState completeCaseInstance);

        [Post("/case-instance/{id}/close")]
        Task Close(string id, [Body] ChangeCaseInstanceState closeCaseInstance);

        [Post("/case-instance/{id}/terminate")]
        Task Terminate(string id, [Body] ChangeCaseInstanceState terminateCaseInstance);
    }
}
