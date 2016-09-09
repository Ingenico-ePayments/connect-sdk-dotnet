using System.Collections.Generic;
using System.Net;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from the GlobalCollect platform when something went wrong at the GlobalCollect platform or further downstream.
    /// </summary>
    public class GlobalCollectException : ApiException
    {
        public GlobalCollectException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base("the GlobalCollect platform returned an error response", statusCode, responseBody, errorId, errors)
        {

        }

        public GlobalCollectException(string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message, statusCode, responseBody, errorId, errors)
        {

        }
    }
}
