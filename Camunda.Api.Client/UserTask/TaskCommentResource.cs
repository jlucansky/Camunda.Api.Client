using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.UserTask
{
    public class TaskCommentResource
    {
        private string _taskId;
        private IUserTaskRestService _api;

        internal TaskCommentResource(IUserTaskRestService api, string taskId)
        {
            _api = api;
            _taskId = taskId;
        }

        /// <summary>
        /// Gets the comments for a task.
        /// </summary>
        public Task<List<CommentInfo>> GetAll() => _api.GetComments(_taskId);
        /// <summary>
        /// Retrieves a single task comment by task id and comment id.
        /// </summary>
        public Task<CommentInfo> Get(string commentId) => _api.GetComment(_taskId, commentId);
        /// <summary>
        /// Create a comment for a task.
        /// </summary>
        /// <param name="message">The message of the task comment to create.</param>
        public Task<CommentInfo> Create(string message) => _api.CreateComment(_taskId, new Comment() { Message = message });

        public override string ToString() => _taskId;
    }
}
