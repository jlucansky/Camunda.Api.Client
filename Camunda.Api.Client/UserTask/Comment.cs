namespace Camunda.Api.Client.UserTask
{
    public class Comment
    {
        /// <summary>
        /// The content of the comment.
        /// </summary>
        public string Message;

        public override string ToString() => Message;
    }
}