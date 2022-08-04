using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Authorization
{
    public class AuthorizationResource
    {
		private IAuthorizationRestService _api;
		private string _authorizationId;

		internal AuthorizationResource(IAuthorizationRestService api, string groupId)
		{
			_api = api;
			_authorizationId = groupId;
		}

		/// <summary>
		/// Retrieves a single group
		/// </summary>
		public Task<AuthorizationInfo> Get() => _api.Get(_authorizationId);

		/// <summary>
		/// Updates a group.
		/// </summary>
		public Task Update(AuthorizationCreateModel authorization) => _api.Update(_authorizationId, authorization);

		/// <summary>
		/// Deletes a group.
		/// </summary>
		public Task Delete() => _api.Delete(_authorizationId);

		
		public override string ToString() => _authorizationId;
	}
}
