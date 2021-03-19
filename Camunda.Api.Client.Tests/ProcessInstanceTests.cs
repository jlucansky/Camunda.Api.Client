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

            mockHttp.Expect(HttpMethod.Post, "http://localhost:8080/engine-rest/process-instance")
                .Respond(HttpStatusCode.OK, "application/json", "[]");


            var client = CamundaClient.Create("http://localhost:8080/engine-rest", mockHttp);
            var process = await client.ProcessInstances.Query().List();

            Assert.NotNull(process);
        }
    }
}
