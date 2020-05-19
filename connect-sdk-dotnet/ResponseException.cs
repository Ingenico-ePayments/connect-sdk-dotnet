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
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets the raw response body that was returned by the Ingenico ePayments platform.
        /// </summary>
        public string Body { get; }

        /// <summary>
        /// Gets the headers that were returned by the Ingenico ePayments platform.
        /// </summary>
        public IEnumerable<IResponseHeader> Headers { get; }

        public ResponseException(HttpStatusCode statusCode, string body, IEnumerable<IResponseHeader> headers) : base()
        {
            Body = body;
            StatusCode = statusCode;
            Headers = headers ?? Enumerable.Empty<IResponseHeader>();
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
        /// Returns the header with the given name, or <c>null</c> if there was no such header.
        /// </summary>
        public IResponseHeader GetHeader(string headerName)
            => Headers.GetHeader(headerName);

        /// <summary>
        /// Returns the value of the header with the given name, or <c>null</c> if there was no such header.
        /// </summary>
        public string GetHeaderValue(string headerName)
            => Headers.GetHeaderValue(headerName);
    }
}
