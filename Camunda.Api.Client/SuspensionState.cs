namespace Camunda.Api.Client
{
    public class SuspensionState
    {
        public bool Suspended;

        public override string ToString() => Suspended.ToString();
    }
}
