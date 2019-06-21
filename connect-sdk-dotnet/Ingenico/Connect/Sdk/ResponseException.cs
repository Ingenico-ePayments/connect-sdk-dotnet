using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Linq;
namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Thrown when a response was received from the Ingenico ePayments platform which indicates an error.
    /// </summary>
    public class ResponseException : Exception
    {
        /// <summary>
        /// Gets the HTTP status code that was returned by the Ingenico ePayments platform.
        /// </summary>
        public HttpStatusCode StatusCode => _statusCode;
        readonly HttpStatusCode _statusCode;

        /// <summary>
        /// Gets the raw response body that was returned by the Ingenico ePayments platform.
        /// </summary>
        public string Body => _body;
        readonly string _body;

        /// <summary>
        /// Gets the headers that were returned by the Ingenico ePayments platform.
        /// </summary>
        public IEnumerable<IResponseHeader> Headers => _headers;
        readonly IEnumerable<IResponseHeader> _headers;

        public ResponseException(HttpStatusCode statusCode, string body, IEnumerable<IResponseHeader> headers) : base()
        {
            _body = body;
            _statusCode = statusCode;
            if (_headers == null)
            {
                _headers = Enumerable.Empty<IResponseHeader>();
            }
            else
            {
                _headers = headers;
            }
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:Ingenico.Connect.Sdk.ResponseException"/>.
        /// </summary>
        /// <returns>A <see cref="T:System.String"/> that represents the current <see cref="T:Ingenico.Connect.Sdk.ResponseException"/>.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            HttpStatusCode statusCode = StatusCode;
            if (statusCode != HttpStatusCode.Unused)
            {
                sb.Append("; statusCode=").Append(statusCode);
            }
            string responseBody = Body;
            if (responseBody != null && responseBody.Length > 0)
            {
                sb.Append("; responseBody='").Append(responseBody).Append("'");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns the header with the given name, or <code>null</code> if there was no such header.
        /// </summary>
        public IResponseHeader GetHeader(string headerName)
        => Headers.GetHeader(headerName);

        /// <summary>
        /// Returns the value of the header with the given name, or <code>null</code> if there was no such header.
        /// </summary>
        public string GetHeaderValue(string headerName)
        => Headers.GetHeaderValue(headerName);
    }
}
