namespace Camunda.Api.Client.History
{
    public class HistoricDecisionInstanceOutputValue : VariableValue
    {
        /// <summary>
        /// The id of the decision output value.
        /// </summary>
        public string Id;

        /// <summary>
        /// The id of the decision instance the output value belongs to.
        /// </summary>
        public string DecisionInstanceId;

        /// <summary>
        /// The id of the clause the output value belongs to.
        /// </summary>
        public string ClauseId;

        /// <summary>
        /// The name of the clause the output value belongs to.
        /// </summary>
        public string ClauseName;

        /// <summary>
        /// The id of the rule the output value belongs to.
        /// </summary>
        public string RuleId;

        /// <summary>
        /// The order of the rule the output value belongs to.
        /// </summary>
        public int RuleOrder;

        /// <summary>
        /// An error message in case a Java Serialized Object could not be de-serialized.
        /// </summary>
        public string ErrorMessage;

        /// <summary>
        /// The name of the output variable.
        /// </summary>
        public string VariableName;
    }
}