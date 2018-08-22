using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Identity
{
	internal interface IIdentityRestService
	{
		[Get("/identity/groups")]
		Task<IdentityGroupMembership> GetMembership(QueryDictionary query);

		[Post("/identity/verify")]
		Task<IdentityVerifiedUser> Verify([Body]IdentityUserCredentials credentials);
	}
}
