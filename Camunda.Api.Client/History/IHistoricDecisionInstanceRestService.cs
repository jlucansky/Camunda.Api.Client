﻿using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    internal interface IHistoricDecisionInstanceRestService
    {
        [Get("/history/decision-instance/{id}")]
        Task<HistoricDecisionInstance> Get(string id);

        [Get("/history/decision-instance")]
        Task<List<HistoricDecisionInstance>> GetList(QueryDictionary query, int? firstResult, int? maxResults);

        [Get("/history/decision-instance/count")]
        Task<CountResult> GetListCount(QueryDictionary query);

        [Post("/history/decision-instance/delete")]
        Task<HistoricDeleteDecisionInstanceResult> Delete([Body] HistoricDeleteDecisionInstance historicDeleteDecisionInstance);

        [Post("/history/decision-instance/set-removal-time")]
        Task<HistoricDeleteDecisionInstanceResult> SetRemovalTime([Body] HistoricSetRemovalTimeDecisionInstance historicSetRemovalTimeDecisionInstance);
    }
}