namespace Camunda.Api.Client.ProcessDefinition
{
    public class ProcessDefinitionDiagram
    {
        /// <summary>
        /// The id of the process definition.
        /// </summary>
        public string Id;
        /// <summary>
        /// XML string containing the XML that this definition was deployed with.
        /// </summary>
        public string Bpmn20Xml;

        public override string ToString() => Id;
    }
}
