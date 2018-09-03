using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.DecisionDefinition
{
    public abstract class DecisionDefinitionResource
    {
        /// <summary>
        /// Retrieves a single decision definition according to the DecisionDefinition interface in the engine.
        /// </summary>
        public abstract Task<DecisionDefinitionInfo> Get();

        /// <summary>
        /// Retrieves the DMN XML of this decision definition.
        /// </summary>
        public abstract Task<DecisionDefinitionDiagram> GetXml();

        /// <summary>
        /// Retrieves the diagram of a decision definition.
        /// </summary>
        public abstract Task<HttpContent> GetDiagram();

        /// <summary>
        /// Evaluates a given decision and returns the result. The input values of the decision have to be supplied in the request body.
        /// </summary>
        public abstract Task<List<Dictionary<string, VariableValue>>> Evaluate(EvaluateDecision parameters);
    }
}