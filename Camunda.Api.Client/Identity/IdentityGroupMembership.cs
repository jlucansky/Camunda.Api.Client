using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.Identity
{
    public class IdentityGroupMembership
    {
        public IdentityGroupMembership()
        {
            Groups = new List<IdentityGroup>();
            GroupUsers = new List<IdentityUser>();
        }
        /// <summary>
        /// List of groups the user is a member of
        /// </summary>
        [JsonProperty("groups")]
        public List<IdentityGroup> Groups { get; set; }
        /// <summary>
        /// List of users who are members of any of the groups 
        /// </summary>
        [JsonProperty("groupUsers")]
        public List<IdentityUser> GroupUsers { get; set; }
    }

    public class IdentityGroup
    {
        public string Id;
        public string Name;
        public override string ToString() => Id;
    }
    public class IdentityUser
    {
        public string Id;
        public string FirstName;
        public string LastName;
        public string DisplayName;
        public override string ToString() => Id;
    }

}
