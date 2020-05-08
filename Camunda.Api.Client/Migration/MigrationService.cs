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
        public Task<MigrationPlan> Generate(MigrationPlanGeneration request) => _api.Generate(request);

        /// <summary>
        /// Validates a migration plan statically without executing it.
        /// </summary>
        /// <param name="plan"></param>
        /// <returns></returns>
        public Task<MigrationPlanReport> Validate(MigrationPlan plan) => _api.Validate(plan);

        /// <summary>
        /// Executes a migration plan synchronously for multiple process instances.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task Execute(MigrationExecution request) => _api.Execute(request);

        /// <summary>
        /// Executes a migration plan asynchronously (batch) for multiple process instances.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<BatchInfo> ExecuteAsync(MigrationExecution request) => _api.ExecuteAsync(request);
    }
}
