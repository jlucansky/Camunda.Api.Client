using Iana;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Camunda.Api.Client
{
    internal class ValueTypeContent : StringContent
    {
        public ValueTypeContent(string valueType) : base(valueType)
        {
            Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data") { Name = "valueType" };
            Headers.ContentType = new MediaTypeHeaderValue(MediaTypes.Text.Plain) { CharSet = "US-ASCII" };
            Headers.Add("Content-Transfer-Encoding", "8bit");
        }
    }
}
