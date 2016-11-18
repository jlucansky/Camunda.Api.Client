namespace Camunda.Api.Client
{
    public class VariableOrder
    {
        public string VariableName;
        public VariableType Type;

        public VariableOrder(string variableName, VariableType variableType)
        {
            VariableName = variableName;
            Type = variableType;
        }
    }
}
