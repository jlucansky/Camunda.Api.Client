namespace Camunda.Api.Client.JobDefinition
{
    public class JobDefinitionPriority
    {
        /// <summary>
        /// The new execution priority number for jobs of the given definition. 
        /// The definition's priority can be reset by using the value null. In that case, the job definition's priority no longer applies but a new job's priority is determined as specified in the process model.
        /// </summary>
        public long? Priority;

        /// <summary>
        /// A boolean value indicating whether existing jobs of the given definition should receive the priority as well. Can only be true when <see cref="Priority"/> is not null.
        /// </summary>
        public bool IncludeJobs;
    }
}
