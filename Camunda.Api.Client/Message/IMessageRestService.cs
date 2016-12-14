using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Message
{
    internal interface IMessageRestService
    {
        [Post("/message")]
        Task<List<CorrelationResult>> DeliverMessage([Body] CorrelationMessage message);
    }
}
