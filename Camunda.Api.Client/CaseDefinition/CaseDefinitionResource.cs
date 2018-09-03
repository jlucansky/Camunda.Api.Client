using Camunda.Api.Client.CaseInstance;
using System.Net.Http;
using System.Threading.Tasks;

namespace Camunda.Api.Client.CaseDefinition
{
    public abstract class CaseDefinitionResource
    {
        /// <summary>
        /// Retrieves a case definition according to the CaseDefinition interface in the engine.
        /// </summary>
        public abstract Task<CaseDefinitionInfo> Get();

        /// <summary>
        /// Retrieves the CMMN XML of a case definition.
        /// </summary>
        public abstract Task<CaseDefinitionDiagram> GetXml();

        /// <summary>
        /// Retrieves the diagram of a case definition.
        /// </summary>
        /// <returns></returns>
        public abstract Task<HttpContent> GetDiagram();

        /// <summary>
        /// Instantiates a given case definition. Case variables and business key may be supplied in the request body.
        /// </summary>
        public abstract Task<CaseInstanceInfo> CreateCaseInstance(CreateCaseInstance parameters);

        // TODO: Update history time to live
    }
}