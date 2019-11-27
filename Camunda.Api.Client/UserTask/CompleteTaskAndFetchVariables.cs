using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.UserTask
{
    public class CompleteTaskAndFetchVariables: CompleteTaskBase
    {
        /// <summary>
        /// Variables will return after completing the task
        /// </summary>
        public override bool WithVariablesInReturn { get; } = true;
    }
}
