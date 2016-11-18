using Camunda.Api.Client.ProcessInstance;
using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessDefinition
{
    public class StartProcessInstance : SubmitStartForm
    {
        /// <summary>
        /// The case instance id the process instance is to be initialized with.
        /// </summary>
        public string CaseInstanceId;

        /// <summary>
        /// Skip execution listener invocation for activities that are started or ended as part of this request.
        /// </summary>
        /// <remarks>
        /// This option is currently only respected when start instructions are submitted via the startInstructions property.
        /// </remarks>
        public bool SkipCustomListeners;
        
        /// <summary>
        /// Skip execution of input/output variable mappings for activities that are started or ended as part of this request.
        /// </summary>
        /// <remarks>
        /// This option is currently only respected when start instructions are submitted via the startInstructions property.
        /// </remarks>
        public bool SkipIoMappings;

        /// <summary>
        /// Array of instructions that specify which activities to start the process instance at. If this property is omitted, the process instance starts at its default blank start event.
        /// The instructions are executed in the order they are in.
        /// </summary>
        public List<ProcessInstanceModificationInstruction> StartInstructions;

        public new StartProcessInstance SetVariable(string name, object value)
        {
            base.SetVariable(name, value);
            return this;
        }

    }
}
