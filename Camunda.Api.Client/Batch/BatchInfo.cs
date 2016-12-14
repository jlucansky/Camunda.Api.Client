namespace Camunda.Api.Client.Batch
{
    public class BatchInfo
    {
        /// <summary>
        /// The id of the batch.
        /// </summary>
        public string Id;
        /// <summary>
        /// The type of the batch.
        /// </summary>
        public string Type;
        /// <summary>
        /// The total jobs of a batch is the number of batch execution jobs required to complete the batch.
        /// </summary>
        public int TotalJobs;
        /// <summary>
        /// The number of batch execution jobs already created by the seed job.
        /// </summary>
        public int JobsCreated;
        /// <summary>
        /// Number	The number of batch execution jobs created per seed job invocation.
        /// The batch seed job is invoked until it has created all batch execution jobs required by the batch (see <see cref="TotalJobs"/> property).
        /// </summary>
        public int BatchJobsPerSeed;
        /// <summary>
        /// Every batch execution job invokes the command executed by the batch invocationsPerBatchJob times.
        /// E.g., for a process instance migration batch this specifies the number of process instances which are migrated per batch execution job.
        /// </summary>
        public int InvocationsPerBatchJob;
        /// <summary>
        /// The job definition id for the seed jobs of this batch.
        /// </summary>
        public string SeedJobDefinitionId;
        /// <summary>
        /// The job definition id for the batch execution jobs of this batch.
        /// </summary>
        public string BatchJobDefinitionId;
        /// <summary>
        /// Indicates whether this batch is suspended or not.
        /// </summary>
        public bool Suspended;
        /// <summary>
        /// The tenant id of the batch.
        /// </summary>
        public string TenantId;
    }
}
