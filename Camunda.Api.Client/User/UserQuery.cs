namespace Camunda.Api.Client.User
{
    public class UserQuery : QueryParameters
    {
        /// <summary>
        /// Filter by the id of the user.
        /// </summary>
        public string Id;
        /// <summary>
        /// Filter by the firstname of the user.
        /// </summary>
        public string FirstName;
        /// <summary>
        /// Filter by the firstname that the parameter is a substring of.
        /// </summary>
        public string FirstNameLike;
        /// <summary>
        /// Filter by the lastname of the user.
        /// </summary>
        public string LastName;
        /// <summary>
        /// Filter by the lastname that the parameter is a substring of.
        /// </summary>
        public string LastNameLike;
        /// <summary>
        /// Filter by the email of the user.
        /// </summary>
        public string Email;
        /// <summary>
        /// Filter by the email that the parameter is a substring of.
        /// </summary>
        public string EmailLike;
        /// <summary>
        /// Filter for users which are members of a group.
        /// </summary>
        public string MemberOfGroup;
        /// <summary>
        /// Filter for users which are members of the given tenant.
        /// </summary>
        public string MemberOfTenant;

        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/>.
        /// </summary>
        public UserSorting SortBy;
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/>.
        /// </summary>
        public SortOrder SortOrder;
    }

    public enum UserSorting
    {
        UserId,
        FirstName,
        LastName,
        Email,
    }
}