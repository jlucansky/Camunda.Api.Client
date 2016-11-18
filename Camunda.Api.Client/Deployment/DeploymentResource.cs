using System.Threading.Tasks;

namespace Camunda.Api.Client.Deployment
{
    public class DeploymentResource
    {
        private IDeploymentRestService _api;
        private string _deploymentId;

        internal DeploymentResource(IDeploymentRestService api, string deploymentId)
        {
            _api = api;
            _deploymentId = deploymentId;
        }

        /// <summary>
        /// Retrieves a single deployment by id.
        /// </summary>
        public Task<DeploymentInfo> Get() => _api.Get(_deploymentId);

        public DeploymentResourcesResource Resources => new DeploymentResourcesResource(_api, _deploymentId);

        /// <summary>
        /// Re-deploy an existing deployment.
        /// </summary>
        /// <remarks>
        /// The deployment resources to re-deploy can be restricted by using the properties resourceIds or resourceNames. 
        /// If no deployment resources to re-deploy are passed then all existing resources of the given deployment are re-deployed.
        /// </remarks>
        public Task<DeploymentInfo> Redeploy(RedeploymentInfo redeployment) => _api.Redeploy(_deploymentId, redeployment);

        /// <summary>
        /// // Deletes a deployment.
        /// </summary>
        public Task Delete() => _api.Delete(_deploymentId);

        public override string ToString() => _deploymentId;
    }
}
