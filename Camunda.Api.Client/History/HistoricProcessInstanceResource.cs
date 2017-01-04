using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricProcessInstanceResource
    {
        private IHistoricProcessInstanceRestService _api;
        private string _processInstanceId;

        internal HistoricProcessInstanceResource(IHistoricProcessInstanceRestService api, string processInstanceId)
        {
            _api = api;
            _processInstanceId = processInstanceId;
        }

        /// <summary>
        /// Retrieves a historic process instance by id, according to the <see cref="HistoricProcessInstance"/> interface in the engine.
        /// </summary>
        public Task<HistoricProcessInstance> Get() => _api.Get(_processInstanceId);

        /// <summary>
        /// Deletes a process instance from the history by id.
        /// </summary>
        public Task Delete() => _api.Delete(_processInstanceId);
    }
}
