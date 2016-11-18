using System.Collections.Generic;

namespace Camunda.Api.Client
{
    public static class EnumerableExtensions
    {
        public static Dictionary<string, VariableValue> Set(this Dictionary<string, VariableValue> variables, string name, object value)
        {
            var varVal = value as VariableValue;

            if (varVal == null)
                varVal = VariableValue.FromObject(value);

            variables[name] = varVal;

            return variables;
        }
    }
}
