using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.UserTask
{
    public class TaskIdentityLinkResource
    {
        private string _taskId;
        private IUserTaskRestService _api;

        internal TaskIdentityLinkResource(IUserTaskRestService api, string taskId)
        {
            _api = api;
            _taskId = taskId;
        }

        /// <summary>
        /// Gets the identity links for a task, which are the users and groups that are in some relation to it (including assignee and owner).
        /// </summary>
        /// <param name="type">Filter by the type of links to include.</param>
        public Task<List<IdentityLink>> GetAll(string type) => _api.GetIdentityLinks(_taskId, type);

        /// <summary>
        /// Gets the identity links for a task, which are the users and groups that are in some relation to it (including assignee and owner).
        /// </summary>
        public Task<List<IdentityLink>> GetAll() => GetAll(null);

        /// <summary>
        /// Adds an identity link to a task. Can be used to link any user or group to a task and specify and relation.
        /// </summary>
        public Task Add(IdentityLink identityLink) => _api.AddIdentityLink(_taskId, identityLink);

        /// <summary>
        /// Removes an identity link from a task.
        /// </summary>
        public Task Delete(IdentityLink identityLink) => _api.DeleteIdentityLink(_taskId, identityLink);

        public override string ToString() => _taskId;
    }
}
