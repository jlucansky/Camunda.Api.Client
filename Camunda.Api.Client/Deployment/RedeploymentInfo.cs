using System.Collections.Generic;

namespace Camunda.Api.Client.Deployment
{
    public class RedeploymentInfo
    {
        /// <summary>
        /// Sets the source of the deployment.
        /// </summary>
        public string Source;
        /// <summary>
        /// A list of deployment resource ids to re-deploy.
        /// </summary>
        public List<string> ResourceIds = new List<string>();
        /// <summary>
        /// A list of deployment resource names to re-deploy.
        /// </summary>
        public List<string> ResourceNames = new List<string>();
    }
}
