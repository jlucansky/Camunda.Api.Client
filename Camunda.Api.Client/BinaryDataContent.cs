using Iana;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Camunda.Api.Client
{
    public class BinaryDataContent : StreamContent
    {
        /// <param name="stream">The binary data to be set.</param>
        /// <param name="fileName">The name of the file. This is not the variable name but the name that will be used when downloading the file again.</param>
        public BinaryDataContent(Stream stream, string fileName = "unspecified") : base(stream)
        {
            Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { FileName = fileName, Name = "data" };
            Headers.ContentType = new MediaTypeHeaderValue(MediaTypes.Application.OctetStream);
            Headers.Add("Content-Transfer-Encoding", "binary");
        }
    }
}
