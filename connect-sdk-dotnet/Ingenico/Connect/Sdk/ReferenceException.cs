using System.Collections.Generic;
using System.Net;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from the Ingenico ePayments platform when a non-existing or removed object is trying to be accessed.
    /// </summary>
    public class ReferenceException : ApiException
    {
        public ReferenceException(HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base("the Ingenico ePayments platform returned an incorrect request error response", statusCode, responseBody, errorId, errors)
        {

        }

        public ReferenceException(string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message, statusCode, responseBody, errorId, errors)
        {

        }
    }
}
