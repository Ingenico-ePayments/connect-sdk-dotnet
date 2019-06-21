using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from the Ingenico ePayments platform which contains an ID and a list of errors.
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Gets the HTTP status code that was returned by the Ingenico ePayments platform.
        /// </summary>
        public System.Net.HttpStatusCode StatusCode => _statusCode;
        readonly System.Net.HttpStatusCode _statusCode;

        /// <summary>
        /// Gets the raw response body that was returned by the Ingenico ePayments platform.
        /// </summary>
        public string ResponseBody => _responseBody;
        readonly string _responseBody;

        /// <summary>
        /// Gets the error identifier received from the Ingenico ePayments platform if available.
        /// </summary>
        public string ErrorId => _errorId;
        readonly string _errorId;

        /// <summary>
        /// Gets the error list received from the Ingenico ePayments platform if available. Never <code>null</code>.
        /// </summary>
        public IList<APIError> Errors => _errors;
        readonly IList<APIError> _errors;

        public ApiException(System.Net.HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : this("the Ingenico ePayments platform returned an error response", statusCode, responseBody, errorId, errors)
        {

        }

        public ApiException(string message, System.Net.HttpStatusCode statusCode, string responseBody, string errorId, IList<APIError> errors)
            : base(message)
        {
            _statusCode = statusCode;
            _responseBody = responseBody;
            _errorId = errorId;
            _errors = errors == null ? new List<APIError>() : errors;
        }

        public override string ToString()
        {
            StringBuilder list = new StringBuilder(base.ToString());
            if (_statusCode > 0)
            {
                list.Append("; statusCode=").Append(_statusCode.ToString());
            }
            if (_responseBody != null && _responseBody.Any())
            {
                list.Append("; responseBody='").Append(_responseBody).Append("'");
            }
            return list.ToString();
        }
    }
}
