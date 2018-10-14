using System.Collections.Generic;

namespace Camunda.Api.Client.CaseExecution
{
    public class CaseExecutionComplete
    {
        public Dictionary<string, VariableValue> Variables = new Dictionary<string, VariableValue>();

        // TODO: deletions
    }
}