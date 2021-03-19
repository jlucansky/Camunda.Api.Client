using System.Linq;
using System.Threading.Tasks;

namespace Camunda.Api.Client.Version
{
    public class VersionService
    {
        private IVersionRestService _api;

        internal VersionService(IVersionRestService api) { _api = api; }

        public Task<VersionInfo> Get() =>
            _api.Get();
    }
}
