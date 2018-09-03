namespace Camunda.Api.Client.CaseDefinition
{
    public class CaseDefinitionDiagram
    {
        /// <summary>
        /// The id of the case definition.
        /// </summary>
        public string Id;

        /// <summary>
        /// An escaped XML string containing the XML that this case definition was deployed with. Carriage returns, line feeds and quotation marks are escaped.
        /// </summary>
        public string CmmnXml;

        public override string ToString() => Id;
    }
}