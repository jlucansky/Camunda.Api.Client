using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.User
{
    public class UserInfo
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
