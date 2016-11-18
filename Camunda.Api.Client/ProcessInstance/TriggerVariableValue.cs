
namespace Camunda.Api.Client.ProcessInstance
{
    public class TriggerVariableValue : VariableValue
    {
        /// <summary>
        ///	Indicates whether the variable should be a local variable or not. If set to true, the variable becomes a local variable of the execution entering the target activity.
        /// </summary>
        public bool Local;

        protected TriggerVariableValue() { }

        /// <param name="value">The variable's value.</param>
        /// <param name="local">Indicates whether the variable should be a local variable or not. If set to true, the variable becomes a local variable of the execution entering the target activity.</param>
        public static TriggerVariableValue FromObject(object value, bool local)
        {
            var val = new TriggerVariableValue();
            val.Local = local;
            val.SetTypedValue(value);
            return val;
        }
    }
}
