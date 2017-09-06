using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Thrown when a response was received from the Ingenico ePayments platform which indicates an error.
    /// </summary>
    public class ResponseException : Exception
    {
        /// <summary>
        /// Gets the response that was returned by the Ingenico ePayments platform.
        /// </summary>
        public Response Response => _response;
        readonly Response _response;

        /// <summary>
        /// Gets the HTTP status code that was returned by the Ingenico ePayments platform.
        /// </summary>
        public HttpStatusCode StatusCode => Response.StatusCode;

        /// <summary>
        /// Gets the raw response body that was returned by the Ingenico ePayments platform.
        /// </summary>
        public string Body => Response.Body;

        /// <summary>
        /// Gets the headers that were returned by the Ingenico ePayments platform.
        /// </summary>
        public IEnumerable<IResponseHeader> Headers => Response.Headers;

        public ResponseException(Response response) : base()
        {
            _response = response;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            HttpStatusCode statusCode = Response.StatusCode;
            if (statusCode != HttpStatusCode.Unused)
            {
                sb.Append("; statusCode=").Append(statusCode);
            }
            string responseBody = Response.Body;
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
            => Response.GetHeader(headerName);

        /// <summary>
        /// Returns the value of the header with the given name, or <code>null</code> if there was no such header.
        /// </summary>
        public string GetHeaderValue(string headerName)
            => Response.GetHeaderValue(headerName);
    }
}
