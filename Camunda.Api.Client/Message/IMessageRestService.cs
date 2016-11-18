using Refit;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Message
{
    internal interface IMessageRestService
    {
        [Post("/message")]
        Task DeliverMessage([Body] CorrelationMessage message);
    }
}
