using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Authorization
{
    public class AuthorizationService
    {
		private IAuthorizationRestService _api;

		internal AuthorizationService(IAuthorizationRestService api)
		{
			_api = api;
		}

		public QueryResource<AuthorizationQuery, AuthorizationInfo> Query(AuthorizationQuery query = null) =>
			new QueryResource<AuthorizationQuery, AuthorizationInfo>(
				query,
				(q, f, m) => _api.GetList(q, f, m),
				q => _api.GetListCount(q));

		/// <param name="groupId">The id of the group to be retrieved.</param>
		public AuthorizationResource this[string groupId] => new AuthorizationResource(_api, groupId);

		/// <summary>
		/// Create a new group.
		/// </summary>
		public Task Create(AuthorizationCreateModel authorization) => _api.Create(authorization);
	}
}
