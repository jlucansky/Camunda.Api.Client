using Camunda.Api.Client.UserTask;
using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Filter
{
    internal interface IFilterRestService
    {
        [Get("/filter")]
        Task<List<FilterInfo.Response>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/filter/count")]
        Task<CountResult> GetListCount(QueryDictionary query);

        [Get("/filter/{id}")]
        Task<FilterInfo.Response> Get(string id);

        [Post("/filter/create")]
        Task<FilterInfo.Response> Create([Body] FilterInfo.Request filterInfo);

        [Delete("/filter/{id}")]
        Task Delete(string id);

        [Put("/filter/{id}")]
        Task Update(string id, [Body] FilterInfo.Request filterInfo);

        [Get("/filter/{id}/singleResult")]
        Task<UserTaskInfo> Execute(string id);

        [Get("/filter/{id}/list")]
        Task<List<UserTaskInfo>> ExecuteList(string id, int firstResult, int maxResults);

        [Get("/filter/{id}/count")]
        Task<CountResult> ExecuteCount(string id);
    }
}
