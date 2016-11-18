
namespace Camunda.Api.Client.Deployment
{
    public class DeploymentResourceInfo
    {
        /// <summary>
        /// The id of the deployment resource.
        /// </summary>
        public string Id;
        /// <summary>
        /// The name of the deployment resource.
        /// </summary>
        public string Name;
        /// <summary>
        /// The id of the deployment.
        /// </summary>
        public string DeploymentId;

        public override string ToString() => Name ?? Id;
    }
}
