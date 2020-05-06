using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Camunda.Api.Client.Batch;

namespace Camunda.Api.Client.Migration
{
    public class MigrationService
    {
        private IMigrationRestService _api;

        internal MigrationService(IMigrationRestService api)
        {
            _api = api;
        }

        /// <summary>
        /// Generates a migration plan for two process definitions. The generated migration plan contains migration instructions which map equal activities between the two process definitions.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<MigrationPlan> Generate(MigrationPlanRequest request) => _api.Generate(request);

        /// <summary>
        /// Validates a migration plan statically without executing it.
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        Task<List<MigrationInstructionReport>> Validate(MigrationPlan plan) => _api.Validate(plan);

        /// <summary>
        /// Executes a migration plan synchronously for multiple process instances.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task Execute(MigrationExecutionRequest request) => _api.Execute(request);

        /// <summary>
        /// Executes a migration plan asynchronously (batch) for multiple process instances.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<BatchInfo> ExecuteAsync(MigrationExecutionRequest request) => _api.ExecuteAsync(request);
    }
}
