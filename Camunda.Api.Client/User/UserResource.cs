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
        /// Retrieves a single user’s profile.
        /// </summary>
        public Task<UserProfileInfo> Get() => _api.GetProfile(_userId);

        /// <summary>
        /// Deletes a user by id.
        /// </summary>
        public Task Delete() => _api.Delete(_userId);

        /// <summary>
        /// Updates the profile information of an already existing user.
        /// </summary>
        public Task Update(UserProfileInfo profile) => _api.UpdateProfile(_userId, profile);

        /// <summary>
        /// Updates a user’s credentials (password).
        /// </summary>
        /// <param name="password">The user's new password.</param>
        /// <param name="authenticatedUserPassword">The password of the current authenticated user who changes the password of the user.</param>
        public Task SetPassword(string password, string authenticatedUserPassword) => 
            _api.UpdateCredentials(_userId, new UserCredentialsInfo() { AuthenticatedUserPassword = authenticatedUserPassword, Password = password });

        public override string ToString() => _userId;
    }
}
