using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Identity
{
    internal class IdentityUserCredentials
    {
        /// <summary>
        /// The id of the user to verify
        /// </summary>
        public string Username;
        /// <summary>
        /// The password of the user to verify
        /// </summary>
        public string Password;

    }
}
