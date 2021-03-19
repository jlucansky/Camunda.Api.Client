using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using RichardSzalay.MockHttp;
using Xunit;

namespace Camunda.Api.Client.Tests
{
    public class VersionTests
    {
        [Fact]
        public async Task GetVersion()
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp.Expect(HttpMethod.Get, "http://localhost:8080/engine-rest/version")
                .Respond(HttpStatusCode.OK, "application/json", "{\"version\": \"7.14.0\"}");


            var client = CamundaClient.Create("http://localhost:8080/engine-rest", mockHttp);
            var version = await client.Version.Get();

            Assert.Equal("7.14.0", version.Version);
        }
    }
}
