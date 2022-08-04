using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Authorization
{
    internal interface IAuthorizationRestService


    {

        [Get("/authorization")]
        Task<List<AuthorizationInfo>> GetList(AuthorizationQuery query, int? firstResult, int? maxResults);

        [Get("/authorization/count")]
        Task<CountResult> GetListCount(AuthorizationQuery query);

        [Get("/authorization/{id}")]
        Task<AuthorizationInfo> Get(string id);

        [Get("authorization/check")]
        Task<AuthorizationCheckResult> Check([Body] AuthorizationCheckQuery query);

        [Post("/authorization/create")]
        Task Create([Body] AuthorizationCreateModel authorizationModel);

        [Delete("/authorization/{id}")]
        Task Delete(string id);

        [Put("/authorization/{id}")]
        Task Update(string id, [Body] AuthorizationCreateModel authorizationModel);


        

    }
}
