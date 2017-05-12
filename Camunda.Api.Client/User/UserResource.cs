using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.User
{
    public class UserResource
    { 
        private string _userId;
        private IUserRestService _api;

        internal UserResource(IUserRestService api, string userId)
        {
            _api = api;
            _userId = userId;
        }

        /// <summary>
        /// Retrieves a single user according to the User interface in the engine.
        /// </summary>
        public Task<UserProfileInfo> Get() => _api.Get(_userId);

        public override string ToString() => _userId;
    }
}
