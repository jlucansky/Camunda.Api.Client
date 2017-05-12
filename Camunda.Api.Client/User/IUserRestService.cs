using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.User
{
    interface IUserRestService
    {
        [Get("/user/{id}")]
        Task<UserProfileInfo> Get(string id);

        [Get("/user")]
        Task<List<UserProfileInfo>> GetList(UserQuery query, int? firstResult, int? maxResults);
    }
}