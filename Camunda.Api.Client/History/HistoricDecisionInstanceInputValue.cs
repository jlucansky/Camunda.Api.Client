namespace Camunda.Api.Client.History
{
    public class HistoricDecisionInstanceInputValue : VariableValue
    {
        /// <summary>
        /// The id of the decision input value.
        /// </summary>
        public string Id;

        /// <summary>
        /// The id of the decision instance the input value belongs to.
        /// </summary>
        public string DecisionInstanceId;

        /// <summary>
        /// The id of the clause the input value belongs to.
        /// </summary>
        public string ClauseId;

        /// <summary>
        /// The name of the clause the input value belongs to.
        /// </summary>
        public string ClauseName;

        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        public string ErrorMessage;
    }
}