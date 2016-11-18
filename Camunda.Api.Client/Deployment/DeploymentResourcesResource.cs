using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Deployment
{
    public class DeploymentResourcesResource
    {
        private IDeploymentRestService _api;
        private string _deploymentId;

        internal DeploymentResourcesResource(IDeploymentRestService api, string deploymentId)
        {
            _api = api;
            _deploymentId = deploymentId;
        }

        /// <summary>
        /// Retrieves all deployment resources of a given deployment.
        /// </summary>
        public Task<List<DeploymentResourceInfo>> GetAll() => _api.GetDeploymentResources(_deploymentId);

        /// <summary>
        /// Retrieves a single deployment resource by resource id for the given deployment.
        /// </summary>
        public Task<DeploymentResourceInfo> Get(string resourceId) => _api.GetDeploymentResource(_deploymentId, resourceId);

        /// <summary>
        /// Retrieves the binary content of a single deployment resource for the given deployment.
        /// </summary>
        public async Task<HttpContent> GetData(string resourceId) => (await _api.GetDeploymentResourceData(_deploymentId, resourceId)).Content;

        public override string ToString() => _deploymentId;
    }
}
