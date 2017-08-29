using System;
using System.Threading.Tasks;
using Camunda.Api.Client.ProcessInstance;
using Xunit;

namespace Camunda.Api.Client.Tests
{
    public class ProcessInstanceTests
    {
        [Fact]
        public async Task GetList()
        {
            var client = CamundaClient.Create("http://localhost:8080/engine-rest");
            var process = await client.ProcessInstances.Query().List();

            Assert.NotNull(process);
        }
    }
}
