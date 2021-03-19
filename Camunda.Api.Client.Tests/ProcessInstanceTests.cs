using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Camunda.Api.Client.ProcessInstance;
using Refit;
using RichardSzalay.MockHttp;
using Xunit;

namespace Camunda.Api.Client.Tests
{
    public class ProcessInstanceTests
    {
        [Fact]
        public async Task GetList()
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp.Expect(HttpMethod.Post, "http://localhost:8080/engine-rest")
                .Respond(HttpStatusCode.OK, "text/html", "OK");


            var client = CamundaClient.Create("http://localhost:8080/engine-rest", mockHttp);
            var process = await client.ProcessInstances.Query().List();

            Assert.NotNull(process);
        }

        [Fact]
        public async Task GetVersion()
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp.Expect(HttpMethod.Get, "http://localhost:8080/engine-rest/version")
                .Respond(HttpStatusCode.OK, "text/html", "{\"version\": \"7.14.0\"}");


            var client = CamundaClient.Create("http://localhost:8080/engine-rest", mockHttp);
            var version = await client.Version.Get();

            Assert.Equal("7.14.0", version.Version);
        }
    }
}
