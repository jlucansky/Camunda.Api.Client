using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Group
{
	internal interface IGroupRestService
	{
		[Get("/group")]
		Task<List<GroupInfo>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

		[Get("/group/count")]
		Task<CountResult> GetListCount(QueryDictionary query);

		[Get("/group/{id}")]
		Task<GroupInfo> Get(string id);

		[Post("/group/create")]
		Task Create([Body] GroupInfo group);

		[Put("/group/{id}")]
		Task Update(string id, [Body] GroupInfo group);

		[Delete("/group/{id}")]
		Task Delete(string id);
	}
}
