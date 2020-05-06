using System.Collections.Generic;
using System.Threading.Tasks;
using Camunda.Api.Client.Batch;
using Refit;

namespace Camunda.Api.Client.Migration
{
    internal interface IMigrationRestService
    {
        [Post("/migration/generate")]
        Task<MigrationPlan> Generate([Body] MigrationPlanRequest request);

        [Post("/migration/validate")]
        Task<MigrationInstructionReports> Validate([Body] MigrationPlan plan);

        [Post("/migration/execute")]
        Task Execute([Body] MigrationExecutionRequest request);

        [Post("/migration/executeAsync")]
        Task<BatchInfo> ExecuteAsync([Body] MigrationExecutionRequest request);
    }
}
