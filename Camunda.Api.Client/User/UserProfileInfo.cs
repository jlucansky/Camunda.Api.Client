namespace Camunda.Api.Client.User
{
    public class UserProfileInfo
    {
        /// <summary>
        /// The id of the user.
        /// </summary>
        public string Id;
        /// <summary>
        /// The firstname of the user.
        /// </summary>
        public string FirstName;
        /// <summary>
        /// The lastname of the user.
        /// </summary>
        public string LastName;
        /// <summary>
        /// The email of the user.
        /// </summary>
        public string Email;

        public override string ToString() => Id;
    }
}
