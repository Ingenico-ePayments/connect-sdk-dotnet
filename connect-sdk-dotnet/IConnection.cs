using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Ingenico.Connect.Sdk.Logging;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents a connection to the GlobalCollect platform server. Thread-safe.
    /// </summary>
    public interface IConnection : IDisposable, ILoggingCapable
    {
        /// <summary>
        /// Send a GET request to the Ingenico ePayments platform.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="responseHandler">A callback that handles the stream from the response</param>
        /// <returns>Returns the object that was returned from the callback</returns>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<R> Get<R>(Uri uri, IEnumerable<IRequestHeader> requestHeaders, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, R> responseHandler);

        /// <summary>
        /// Send a DELETE request to the Ingenico ePayments platform.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="responseHandler">A callback that handles the stream from the response</param>
        /// <returns>Returns the object that was returned from the callback</returns>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<R> Delete<R>(Uri uri, IEnumerable<IRequestHeader> requestHeaders, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, R> responseHandler);

        /// <summary>
        /// Send a POST request to the Ingenico ePayments platform.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="body">The optional body to send.</param>
        /// <param name="responseHandler">A callback that handles the stream from the response</param>
        /// <returns>Returns the object that was returned from the callback</returns>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<R> Post<R>(Uri uri, IEnumerable<IRequestHeader> requestHeaders, string body, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, R>  responseHandler);

        /// <summary>
        /// Send a multipart/form-data POST request to the Ingenico ePayments platform.
        ///
        /// The content type of the request will be be part of the given request header list.
        /// If the connection creates its own content type, it should be multipart.getContentType().
        /// Otherwise, authentication failures will occur.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="multipart">The multipart/form-data request to send.</param>
        /// <param name="responseHandler">A callback that handles the stream from the response</param>
        /// <returns>Returns the object that was returned from the callback</returns>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<R> Post<R>(Uri uri, IEnumerable<IRequestHeader> requestHeaders, MultipartFormDataObject multipart, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, R> responseHandler);

        /// <summary>
        /// Send a PUT request to the Ingenico ePayments platform.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="responseHandler">A callback that handles the stream from the response</param>
        /// <returns>Returns the object that was returned from the callback</returns>
        /// <param name="body">The optional body to send.</param>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<R> Put<R>(Uri uri, IEnumerable<IRequestHeader> requestHeaders, string body, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, R>  responseHandler);

        /// <summary>
        /// Send a multipart/form-data PUT request to the Ingenico ePayments platform.
        ///
        /// The content type of the request will be be part of the given request header list.
        /// If the connection creates its own content type, it should be multipart.getContentType().
        /// Otherwise, authentication failures will occur.
        /// </summary>
        /// <param name="uri">The URI to call, including any necessary query parameters.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="multipart">The multipart/form-data request to send.</param>
        /// <param name="responseHandler">A callback that handles the stream from the response</param>
        /// <returns>Returns the object that was returned from the callback</returns>
        /// <exception cref="CommunicationException">when an exception occurred communicating with the Ingenico ePayments platform</exception>
        Task<R> Put<R>(Uri uri, IEnumerable<IRequestHeader> requestHeaders, MultipartFormDataObject multipart, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, R> responseHandler);
    }
}
