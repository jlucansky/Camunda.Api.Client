using System.Collections.Generic;

namespace Camunda.Api.Client.UserTask
{
    public class CompleteTask : ResolveTask
    {
        /// <summary>
        /// if set to true, API will return variables in response. Default behaviour is "false"
        /// </summary>
        public bool? WithVariablesInReturn { get; set; } = null;

        public new CompleteTask SetVariable(string name, object value)
        {
            base.SetVariable(name, value);
            return this;
        }
    }
}
