namespace Camunda.Api.Client.JobDefinition
{
    public class JobDefinitionInfo
    {
        /// <summary>
        /// The id of the job definition.
        /// </summary>
        public string Id;
        /// <summary>
        /// The id of the process definition this job definition is associated with.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The key of the process definition this job definition is associated with.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The type of the job which is running for this job definition, for example: asynchronous continuation, timer etc.
        /// </summary>
        public string JobType;
        /// <summary>
        /// The configuration of a job definition provides details about the jobs which will be created, for example: for timer jobs it is the timer configuration.
        /// </summary>
        public string JobConfiguration;
        /// <summary>
        /// The id of the activity this job definition is associated with.
        /// </summary>
        public string ActivityId;
        /// <summary>
        /// Indicates whether this job definition is suspended or not.
        /// </summary>
        public bool Suspended;
        /// <summary>
        /// The execution priority defined for jobs that are created based on this definition. May be null when the priority has not been overridden on the job definition level.
        /// </summary>
        public long? OverridingJobPriority;
        /// <summary>
        /// The id of the tenant this job definition is associated with.
        /// </summary>
        public string TenantId;

        public override string ToString() => Id;
    }
}
