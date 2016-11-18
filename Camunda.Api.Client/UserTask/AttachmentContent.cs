using Iana;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Camunda.Api.Client.UserTask
{
    public class AttachmentContent : StreamContent
    {
        /// <param name="stream">The binary data to be set.</param>
        public AttachmentContent(Stream stream) : base(stream)
        {
            Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { Name = "content" };
            Headers.ContentType = new MediaTypeHeaderValue(MediaTypes.Application.OctetStream);
            Headers.Add("Content-Transfer-Encoding", "binary");
        }
    }
}
