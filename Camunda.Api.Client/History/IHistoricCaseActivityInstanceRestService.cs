using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricCaseActivityInstanceRestService
    {
        [Get("/history/case-activity-instance/{id}")]
        Task<HistoricCaseActivityInstance> Get(string id);

        [Get("/history/case-activity-instance")]
        Task<List<HistoricCaseActivityInstance>> GetList(string caseInstanceId, int? firstResult, int? maxResults);

        [Get("/history/case-activity-instance/count")]
        Task<CountResult> GetListCount(string caseInstanceId);
    }
}