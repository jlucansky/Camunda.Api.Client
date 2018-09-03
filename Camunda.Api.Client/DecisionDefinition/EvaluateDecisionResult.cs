using System.Collections.Generic;

namespace Camunda.Api.Client.DecisionDefinition
{
    public class EvaluateDecisionResult
    {
        /// <summary>
        /// An object containing the variables the decision is to be evaluated with. Each key corresponds to a variable name and each value to a variable value.
        /// </summary>
        public KeyValuePair<string, VariableValue> Variables { get; set; }
    }
}