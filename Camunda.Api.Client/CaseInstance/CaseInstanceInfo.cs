namespace Camunda.Api.Client.CaseInstance
{
    public class CaseInstanceInfo
    {
        /// <summary>
        /// The id of the case instance.
        /// </summary>
        public string Id;

        /// <summary>
        /// The id of the case definition this case instance belongs to.
        /// </summary>
        public string CaseDefinitionId;

        /// <summary>
        /// The id of the tenant this case instance belongs to.
        /// </summary>
        public string TenantId;

        /// <summary>
        /// The business key of the case instance.
        /// </summary>
        public string BusinessKey;

        /// <summary>
        /// A flag indicating whether the case instance is active or not.
        /// </summary>
        public bool Active;

        /// <summary>
        /// A flag indicating whether the case instance is completed or not.
        /// </summary>
        public bool Completed;

        public override string ToString() => Id;
    }
}