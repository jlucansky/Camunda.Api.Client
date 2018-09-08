namespace Camunda.Api.Client.CaseExecution
{
    public class CaseExecutionInfo
    {
        /// <summary>
        /// The id of the case execution.
        /// </summary>
        public string Id;

        /// <summary>
        /// A flag indicating whether the case execution is active or not.
        /// </summary>
        public bool Active;

        /// <summary>
        /// The description of the activity this case execution belongs to.
        /// </summary>
        public string ActivityDescription;

        /// <summary>
        /// The id of the activity this case execution belongs to.
        /// </summary>
        public string ActivityId;

        /// <summary>
        /// The name of the activity this case execution belongs to.
        /// </summary>
        public string ActivityName;

        /// <summary>
        /// The type of the activity this case execution belongs to.
        /// </summary>
        public string ActivityType;

        /// <summary>
        /// The id of the case definition this case execution belongs to.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        /// The id of the case instance this case execution belongs to.
        /// </summary>
        public string CaseInstanceId;

        /// <summary>
        /// A flag indicating whether the case execution is disabled or not.
        /// </summary>
        public bool Disabled;

        /// <summary>
        /// A flag indicating whether the case execution is enabled or not.
        /// </summary>
        public bool Enabled;

        /// <summary>
        /// The id of the parent of this case execution belongs to.
        /// </summary>
        public string ParentId;

        /// <summary>
        /// A flag indicating whether the case execution is repeatable or not.
        /// </summary>
        public bool Repeatable;

        /// <summary>
        /// A flag indicating whether the case execution is a repetition or not.
        /// </summary>
        public bool Repetition;

        /// <summary>
        /// A flag indicating whether the case execution is required or not.
        /// </summary>
        public bool Required;

        /// <summary>
        /// The tenant id of the case execution.
        /// </summary>
        public string TenantId;

        public override string ToString() => Id;
    }
}
