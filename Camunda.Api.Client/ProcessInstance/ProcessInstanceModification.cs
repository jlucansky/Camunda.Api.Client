using System.Collections.Generic;

namespace Camunda.Api.Client.ProcessInstance
{
    public class ProcessInstanceModification
    {
        /// <summary>
        /// Skip execution listener invocation for activities that are started or ended as part of this request.
        /// </summary>
        public bool SkipCustomListeners = false;
        /// <summary>
        /// Skip execution of input/output variable mappings for activities that are started or ended as part of this request.
        /// </summary>
        public bool SkipIoMappings = false;
        /// <summary>
        /// An array of modification instructions. The instructions are executed in the order they are in. 
        /// </summary>
        public List<ProcessInstanceModificationInstruction> Instructions = new List<ProcessInstanceModificationInstruction>();
    }
}
