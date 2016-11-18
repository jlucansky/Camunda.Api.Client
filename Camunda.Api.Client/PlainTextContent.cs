using Iana;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Camunda.Api.Client
{
    internal class PlainTextContent : StringContent
    {
        public PlainTextContent(string partName, string text) : base(text ?? "")
        {
            Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { Name = partName };
            Headers.ContentType = new MediaTypeHeaderValue(MediaTypes.Text.Plain) { CharSet = "UTF-8" };
            Headers.Add("Content-Transfer-Encoding", "8bit");
        }
    }
}
