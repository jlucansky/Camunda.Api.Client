using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http;
using System.Reflection;

namespace Camunda.Api.Client
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ApiException : Exception
    {
        public string ErrorType { get; }
        public HttpResponseMessage Response { get; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly ConcurrentDictionary<string, Func<string, string, HttpResponseMessage, ApiException>> _knownTypes =
            new ConcurrentDictionary<string, Func<string, string, HttpResponseMessage, ApiException>>();

        public ApiException(string type, string message, HttpResponseMessage response) : base(message)
        {
            ErrorType = type;
            Response = response;
        }

        private static Func<string, string, HttpResponseMessage, ApiException> GetConstructor(string typeName)
        {
            return _knownTypes.GetOrAdd(typeName, typeName_ =>
            {
                Type t = Type.GetType($"{typeof(ApiException).Namespace}.{typeName_}");

                if (t == null || !typeof(ApiException).IsAssignableFrom(t))
                    return null;

                var paramType = Expression.Parameter(typeof(string));
                var paramMessage = Expression.Parameter(typeof(string));
                var paramResponse = Expression.Parameter(typeof(HttpResponseMessage));

                var ctor = t.GetConstructor(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { paramType.Type, paramMessage.Type, paramResponse.Type }, null);

                if (ctor == null)
                    return null;

                var newExpression = Expression.New(ctor, paramType, paramMessage, paramResponse);
                var lambda = Expression.Lambda<Func<string, string, HttpResponseMessage, ApiException>>(newExpression, paramType, paramMessage, paramResponse);

                return lambda.Compile();
            });
        }

        public static ApiException FromRestError(RestError restError, HttpResponseMessage response)
        {
            var ctor = GetConstructor(restError.Type);
            if (ctor != null)
                return ctor(restError.Type, restError.Message, response);
            else
                return new ApiException(restError.Type, restError.Message, response);
        }
    }

    /// <summary>
    /// Exception thrown by the process engine in case a user tries to interact with a resource in an unauthorized way.
    /// </summary>
    public class AuthorizationException : ApiException
    {
        [JsonProperty]
        public string UserId { get; private set; }
        [JsonProperty]
        public string PermissionName { get; private set; }
        [JsonProperty]
        public string ResourceName { get; private set; }
        [JsonProperty]
        public string ResourceId { get; private set; }

        public AuthorizationException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// RuntimeException is the superclass of those exceptions that can be thrown during the normal operation of the Java Virtual Machine
    /// </summary>
    public class RuntimeException : ApiException
    {
        public RuntimeException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }

    public class RestException : RuntimeException
    {
        public RestException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }

    /// <summary>
    /// This exception is used for any kind of errors that occur due to malformed parameters in a Http query.
    /// </summary>
    public class InvalidRequestException : RestException
    {
        public InvalidRequestException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }

    /// <summary>
    /// Runtime exception that is the superclass of all exceptions in the process engine.
    /// </summary>
    public class ProcessEngineException : RuntimeException
    {
        public ProcessEngineException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }

    /// <summary>
    /// Exception resulting from a bad user request. A bad user request is an interaction where the user requests some non-existing state or attempts to perform an illegal action on some entity.
    /// </summary>
    public class BadUserRequestException : ProcessEngineException
    {
        public BadUserRequestException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Exception during the parsing of an BPMN model.
    /// </summary>
    public class BpmnParseException : ProcessEngineException
    {
        public BpmnParseException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Runtime exception indicating the requested class was not found or an error occurred while loading the class.
    /// </summary>
    public class ClassLoadingException : ProcessEngineException
    {
        [JsonProperty]
        public string ClassName { get; private set; }

        public ClassLoadingException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Exception that is thrown when an optimistic locking occurs in the datastore  caused by concurrent access of the same data entry.
    /// </summary>
    public class OptimisticLockingException : ProcessEngineException
    {
        public OptimisticLockingException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Exception resulting from a error during a script compilation.
    /// </summary>
    public class ScriptEngineException : ProcessEngineException
    {
        public ScriptEngineException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// This exception is thrown when you try to claim a task that is already claimed by someone else.
    /// </summary>
    public class TaskAlreadyClaimedException : ProcessEngineException
    {
        public TaskAlreadyClaimedException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Exception that is thrown when the Activiti engine discovers a mismatch between the database schema version and the engine version.
    /// </summary>
    public class WrongDbException : ProcessEngineException
    {
        public WrongDbException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Special exception that can be used to throw a BPMN Error from JavaDelegate and expressions.
    /// This should only be used for business faults, which shall be handled by a Boundary Error Event or Error Event Sub-Process modeled in the process definition.
    /// Technical errors should be represented by other exception types.
    /// </summary>
    public class BpmnError : ProcessEngineException
    {
        [JsonProperty]
        public string ErrorCode { get; private set; }
        [JsonProperty]
        public string ErrorMessage { get; private set; }

        public BpmnError(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    public class DeploymentResourceNotFoundException : ProcessEngineException
    {
        public DeploymentResourceNotFoundException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    public class NullValueException : ProcessEngineException
    {
        public NullValueException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// This is exception is thrown when a specific case definition is not found.
    /// </summary>
    public class CaseException : ProcessEngineException
    {
        public CaseException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// This exception is thrown when a specific decision definition is not found.
    /// </summary>
    public class DecisionException : ProcessEngineException
    {
        public DecisionException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    public class FormException : ProcessEngineException
    {
        public FormException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Marks an exception triggered inside an identity provider implementation.
    /// </summary>
    public class IdentityProviderException : ProcessEngineException
    {
        public IdentityProviderException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Represents any of the exception conditions that can arise during expression evaluation.
    /// </summary>
    public class ELException : ProcessEngineException
    {
        public ELException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    public class PvmException : ProcessEngineException
    {
        public PvmException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Thrown if at least one migration instruction cannot be applied to the activity instance it matches.
    /// </summary>
    public class MigratingProcessInstanceValidationException : ProcessEngineException
    {
        public MigratingProcessInstanceValidationException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Represents an exception in activiti cdi.
    /// </summary>
    public class ProcessEngineCdiException : ProcessEngineException
    {
        public ProcessEngineCdiException(string type, string message, HttpResponseMessage response)
            :base(type, message, response) { }
    }

    /// <summary>
    /// Unable to bootstrap server.
    /// </summary>
    public class ServerBootstrapException : RuntimeException
    {
        public ServerBootstrapException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }

    /// <summary>
    /// The JSONException is thrown by the JSON.org classes when things are amiss.
    /// </summary>
    public class JSONException : RuntimeException
    {
        public JSONException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }

    public class HalRelationCacheConfigurationException : RuntimeException
    {
        public HalRelationCacheConfigurationException(string type, string message, HttpResponseMessage response)
            : base(type, message, response) { }
    }
}
