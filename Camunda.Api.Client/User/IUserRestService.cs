using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.User
{
    interface IUserRestService
    {
        [Get("/user/{id}")]
        Task<UserInfo> Get(string id);

        [Get("/user")]
        Task<List<UserInfo>> GetList(UserQuery query, int? firstResult, int? maxResults);
    }
}