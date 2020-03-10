using System.Collections.Generic;
using System.Net;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from the Ingenico ePayments platform when an idempotent request failed because the first request has not finished yet.
    /// </summary>
    public class IdempotenceException : ApiException
    {
        /// <summary>
        /// Gets the key that was used for the idempotent request.
        /// </summary>
        public string IdempotenceKey { get; }

        /// <summary>
        /// Gets the request timestamp of the first idempotent request with the same key.
        /// </summary>
        public long? IdempotenceRequestTimestamp { get; }

        public IdempotenceException(string idempotenceKey, long? idempotenceRequestTimestamp, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : this(idempotenceKey, idempotenceRequestTimestamp, "the Ingenico ePayments platform returned a duplicate request error response", statusCode, responseBody, errorId, errors)
        {

        }

        public IdempotenceException(string idempotenceKey, long? idempotenceRequestTimestamp, string message, HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message, statusCode, responseBody, errorId, errors)
        {
            IdempotenceKey = idempotenceKey;
            IdempotenceRequestTimestamp = idempotenceRequestTimestamp;
        }
    }
}
