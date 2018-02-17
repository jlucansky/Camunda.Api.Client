using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.User
{
    internal interface IUserRestService
    {
        [Get("/user")]
        Task<List<UserProfileInfo>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/user/count")]
        Task<CountResult> GetListCount(QueryDictionary query);

        [Get("/user/{id}/profile")]
        Task<UserProfileInfo> GetProfile(string id);

        [Put("/user/{id}/profile")]
        Task UpdateProfile(string id, [Body] UserProfileInfo profile);

        [Put("/user/{id}/credentials")]
        Task UpdateCredentials(string id, [Body] UserCredentialsInfo credentials);

        [Delete("/user/{id}")]
        Task Delete(string id);

        [Post("/user/create")]
        Task Create([Body] CreateUser createUser);
    }
}
