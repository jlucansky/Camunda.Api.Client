using Iana;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Camunda.Api.Client
{
    public class ErrorMessageHandler : DelegatingHandler
    {
        public ErrorMessageHandler(HttpMessageHandler innerHandler) : base(innerHandler)
        {
        }

        public ErrorMessageHandler() : base(new HttpClientHandler())
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);

            if (response.IsSuccessStatusCode == false && 
                response.Content?.Headers?.ContentType?.MediaType?.Equals(MediaTypes.Application.Json) == true)
            {
                RestError err = null;
                string json = null;
                try
                {
                    json = await response.Content.ReadAsStringAsync();
                    err = JsonConvert.DeserializeObject<RestError>(json);
                }
                catch
                {
                    // we are currently handling exception, don't throw another one during deserialization
                }

                if (err?.Type != null)
                {
                    var ex = ApiException.FromRestError(err, response);
                    
                    // fill additional exception properties
                    JsonConvert.PopulateObject(json, ex); 

                    throw ex;
                }
            }

            return response;
        }
    }
}
