
namespace Camunda.Api.Client
{
    public class NamedVariableValue : VariableValue
    {
        public string Name;

        protected NamedVariableValue() { }

        public static NamedVariableValue FromObject(string name, object value)
        {
            var val = new NamedVariableValue();
            val.Name = name;
            val.SetTypedValue(value);
            return val;
        }

        public override string ToString() => $"{Name} = {base.ToString()}";
    }
}
