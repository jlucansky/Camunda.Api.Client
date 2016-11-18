namespace Camunda.Api.Client.UserTask
{
    public class AttachmentInfo
    {
        public string Id;
        public string Name;
        public string Description;
        public string TaskId;
        public string Type;
        public string Url;

        public override string ToString() => Id;
    }
}
