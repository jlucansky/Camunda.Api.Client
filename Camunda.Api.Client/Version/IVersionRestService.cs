using Refit;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Version
{
    internal interface IVersionRestService
    {
        [Get("/version")]
        Task<VersionInfo> Get();
    }
}