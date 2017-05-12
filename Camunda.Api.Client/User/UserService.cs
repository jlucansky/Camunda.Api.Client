using System.Threading.Tasks;

namespace Camunda.Api.Client.User
{
    public class UserService
    {
        private IUserRestService _api;

        internal UserService(IUserRestService api) { _api = api; }

        public QueryResource<UserQuery, UserProfileInfo> Query(UserQuery query = null) =>
            new QueryResource<UserQuery, UserProfileInfo>(_api, query);

        /// <param name="userId">The id of the user to be retrieved.</param>
        public UserResource this[string userId] => new UserResource(_api, userId);

        /// <summary>
        /// Create a new user.
        /// </summary>
        /// <param name="profile">The user's profile</param>
        /// <param name="password">The user's password.</param>
        /// <returns></returns>
        public Task Create(UserProfileInfo profile, string password) => 
            _api.Create(new CreateUser() { Profile = profile, Credentials = new UserCredentialsInfo { Password = password } });

    }
}
