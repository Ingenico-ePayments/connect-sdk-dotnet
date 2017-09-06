using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ingenico.Connect.Sdk.Logging;

namespace Ingenico.Connect.Sdk
{
    public interface IConnection : IDisposable, ILoggingCapable
    {
        /// <summary>
        /// Send a GET request to the Ingenico ePayments platform and return the response.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<Response> Get(Uri uri, IEnumerable<IRequestHeader> requestHeaders);

        /// <summary>
        /// Send a DELETE request to the Ingenico ePayments platform and return the response.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<Response> Delete(Uri uri, IEnumerable<IRequestHeader> requestHeaders);

        /// <summary>
        /// Send a POST request to the Ingenico ePayments platform and return the response.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="body">The optional body to send.</param>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<Response> Post(Uri uri, IEnumerable<IRequestHeader> requestHeaders, string body);

        /// <summary>
        /// Send a PUT request to the Ingenico ePayments platform and return the response.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="body">The optional body to send.</param>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<Response> Put(Uri uri, IEnumerable<IRequestHeader> requestHeaders, string body);
    }
}
