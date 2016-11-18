using System.Collections.Generic;

namespace Camunda.Api.Client
{
    public class PatchVariables
    {
        /// <summary>
        /// A object containing variable key-value pairs.
        /// </summary>
        public Dictionary<string, VariableValue> Modifications;

        /// <summary>
        /// An array of String keys of variables to be deleted.
        /// </summary>
        public List<string> Deletions;
    }
}
