using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.UserTask
{
    public class TaskAttachmentResource
    {
        private string _taskId;
        private IUserTaskRestService _api;

        internal TaskAttachmentResource(IUserTaskRestService api, string taskId)
        {
            _api = api;
            _taskId = taskId;
        }

        /// <summary>
        /// Gets the attachments for a task.
        /// </summary>
        public Task<List<AttachmentInfo>> GetAll() => _api.GetAttachments(_taskId);

        /// <summary>
        /// Retrieves a single task attachment by task id and attachment id.
        /// </summary>
        public Task<AttachmentInfo> Get(string attachmentId) => _api.GetAttachment(_taskId, attachmentId);

        /// <summary>
        /// Retrieves the binary content of a single task attachment by task id and attachment id.
        /// </summary>
        public async Task<HttpContent> GetData(string attachmentId) => (await _api.GetAttachmentData(_taskId, attachmentId)).Content;

        /// <summary>
        /// Removes an attachment from a task.
        /// </summary>
        public Task Delete(string attachmentId) => _api.DeleteAttachment(_taskId, attachmentId);

        /// <summary>
        /// Create an attachment for a task.
        /// </summary>
        /// <param name="name">The name of the attachment.</param>
        /// <param name="description">The description of the attachment.</param>
        /// <param name="type">The type of the attachment. Can be MIME type or any other indication.</param>
        /// <param name="url">The url to the remote content of the attachment.</param>
        /// <param name="content">The content of the attachment.</param>
        public Task<AttachmentInfo> Create(string name, string description, string type, string url, AttachmentContent content) => 
            _api.AddAttachment(_taskId, new PlainTextContent("attachment-name", name), new PlainTextContent("attachment-description", description),
                new PlainTextContent("attachment-type", type), new PlainTextContent("url", url), content);

        public override string ToString() => _taskId;
    }
}
