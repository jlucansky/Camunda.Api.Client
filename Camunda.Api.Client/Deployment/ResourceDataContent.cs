using Iana;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Camunda.Api.Client.Deployment
{
    public class ResourceDataContent : StreamContent
    {
        /// <param name="stream">The binary data to create the deployment resource.</param>
        /// <param name="fileName">The name of the file.</param>
        public ResourceDataContent(Stream stream, string fileName ) : base(stream)
        {
            Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { FileName = fileName, Name = "data-" + Guid.NewGuid().ToString("D") };
            Headers.ContentType = new MediaTypeHeaderValue(MediaTypes.Application.OctetStream);
            Headers.Add("Content-Transfer-Encoding", "binary");
        }

    }
}
