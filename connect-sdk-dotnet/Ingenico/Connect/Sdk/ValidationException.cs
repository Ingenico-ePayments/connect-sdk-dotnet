using System.Collections.Generic;
using System.Net;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from the GlobalCollect platform when validation of requests failed.
    /// </summary>
    public class AuthorizationException : ApiException
    {
        public AuthorizationException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base("The GlobalCollect platform returned an incorrect request error response", statusCode, responseBody, errorId, errors)
        {

        }

        public AuthorizationException(string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors) : base(message, statusCode, responseBody, errorId, errors)
        {

        }
    }
}
