using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// A response from the GlobalCollect platform.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Gets The HTTP status code that was returned by the GlobalCollect platform
        /// </summary>
        public HttpStatusCode StatusCode => _statusCode;
        readonly HttpStatusCode _statusCode;

        /// <summary>
        /// Gets the raw response body that was returned by the GlobalCollect platform.
        /// </summary>
        public string Body => _body;
        readonly string _body;

        /// <summary>
        /// Gets the headers that were returned by the GlobalCollect platform. Never <code>null</code>.
        /// </summary>
        public IEnumerable<IResponseHeader> Headers => _headers;
        readonly IEnumerable<IResponseHeader> _headers;

        public Response(HttpStatusCode statusCode, string body, IEnumerable<IResponseHeader> headers)
        {
            _statusCode = statusCode;
            _body = body;
            _headers = headers == null ? Enumerable.Empty<IResponseHeader>() : headers;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(GetType().FullName)
                .Append("[statusCode=").Append(StatusCode.ToString());
            if (Body != null && Body.Length > 0)
            {
                sb.Append(",body='").Append(Body).Append("'");
            }
            if (Headers.Any())
            {
                sb.Append(",headers=").Append(Headers.ToString());
            }
            return sb.Append("]").ToString();
        }

        /// <summary>
        /// Gets the specified header.
        /// </summary>
        /// <param name="headerName">Header name.</param>
        /// <returns>The header with the given name, or <code>null</code> if there is no such header.</returns>
        public IResponseHeader GetHeader(string headerName)
        {
            if (Headers == null)
            {
                return null;
            }
            foreach (IResponseHeader header in Headers)
            {
                if (header.Name.Equals(headerName, System.StringComparison.OrdinalIgnoreCase))
                {
                    return header;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the value of the specified header.
        /// </summary>
        /// <param name="headerName">Header name.</param>
        /// <returns>The header value, or <code>null</code> if there is no such header.</returns>
        public string GetHeaderValue(string headerName)
        {
            return GetHeader(headerName)?.Value;
        }
    }
}
