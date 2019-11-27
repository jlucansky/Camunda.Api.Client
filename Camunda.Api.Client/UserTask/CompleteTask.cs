using System.Collections.Generic;

namespace Camunda.Api.Client.UserTask
{
    public class CompleteTask: CompleteTaskBase
    {
        public override bool WithVariablesInReturn => false;
    }
}
