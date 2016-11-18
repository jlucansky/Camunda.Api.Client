using System;

namespace Camunda.Api.Client.Deployment
{
    public class DeploymentInfo
    {
        /// <summary>
        /// The id of the deployment.
        /// </summary>
        public string Id;
        /// <summary>
        /// The name of the deployment.
        /// </summary>
        public string Name;
        /// <summary>
        /// The source of the deployment.
        /// </summary>
        public string Source;
        /// <summary>
        /// The time when the deployment was created.
        /// </summary>
        public DateTime DeploymentTime;
        /// <summary>
        /// The tenant id of the deployment.
        /// </summary>
        public string TenantId;

        public override string ToString() => Name ?? Id;

    }
}
