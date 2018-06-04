using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricDetailResource
    {
        private IHistoricDetailRestService _api;
        private string _historicDetailId;

        internal HistoricDetailResource(IHistoricDetailRestService api, string historicDetailId)
        {
            _api = api;
            _historicDetailId = historicDetailId;
        }

        /// <summary>
        /// Retrieves a historic detail by id.
        /// </summary>
        public Task<HistoricDetail> Get() => _api.Get(_historicDetailId);

        /// <summary>
        /// 
        /// </summary>
        public async Task<HttpContent> GetData() => (await _api.GetData(_historicDetailId)).Content;

    }
}
