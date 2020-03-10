using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Ingenico.Connect.Sdk.Logging;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Used to communicate with the Ingenico ePayments platform web services.
    /// </summary>
    /// <remarks>
    /// It contains all the logic to transform a request object to a HTTP request and a HTTP response to a response object.
    /// It is also thread safe.
    /// </remarks>
    public class Communicator : IDisposable, ILoggingCapable
    {
        /// <summary>
        /// Gets the <see cref="IMarshaller"/> object associated with this communicator. Never <code>null</code>.
        /// </summary>
        public IMarshaller Marshaller { get; }

        public Communicator(Session session, IMarshaller marshaller)
        {
            Session = session ?? throw new ArgumentException("session is required");
            Marshaller = marshaller ?? throw new ArgumentException("marshaller is required");
        }

        #region IDisposable implementation
        /// <summary>
        /// Releases all resource used by the <see cref="T:Ingenico.Connect.Sdk.Communicator"/> object.
        /// </summary>
        /// <remarks>Call <see cref="Dispose"/> when you are finished using the
        /// <see cref="T:Ingenico.Connect.Sdk.Communicator"/>. The <see cref="Dispose"/> method leaves the
        /// <see cref="T:Ingenico.Connect.Sdk.Communicator"/> in an unusable state. After calling <see cref="Dispose"/>,
        /// you must release all references to the <see cref="T:Ingenico.Connect.Sdk.Communicator"/> so the garbage
        /// collector can reclaim the memory that the <see cref="T:Ingenico.Connect.Sdk.Communicator"/> was occupying.</remarks>
        public void Dispose()
        {
            Session.Connection.Dispose();
        }
        #endregion

        #region ILoggingCapable implementation
        public void EnableLogging(ICommunicatorLogger communicatorLogger)
        {
            Session.Connection.EnableLogging(communicatorLogger);
        }

        public void DisableLogging()
        {
            Session.Connection.DisableLogging();
        }
        #endregion

        #region HTTP methods
        /// <summary>
        /// Corresponds to the HTTP Get method.
        /// </summary>
        /// <param name="relativePath">The path to call, relative to the base URI.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="requestParameters">The optional set of request parameters.</param>
        /// <param name="context">The optional call context to use</param>
        /// <typeparam name="T">Type of the response.</typeparam>
        /// <exception cref="CommunicationException"> when an exception occurred communicating with the Ingenico ePayments platform</exception>
        /// <exception cref="ResponseException">when an error response was received from the Ingenico ePayments platform</exception>
        /// <exception cref="ApiException">when an error response was received from the Ingenico ePayments platform which contained a list of errors</exception>
        public async Task<T> Get<T>(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                                    CallContext context)
        {
            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();
            requestHeaders = AddGenericHeaders(HttpMethod.Get, uri, requestHeaders, context);
            return await connection.Get<T>(uri, requestHeaders, (status, body, headers) => {
                return ProcessResponse<T>(status, body, headers, relativePath, context);
            });
        }

        /// <summary>
        /// Corresponds to the HTTP Get method.
        /// </summary>
        /// <param name="relativePath">The path to call, relative to the base URI.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="requestParameters">The optional set of request parameters.</param>
        /// <param name="bodyHandler">A callback that receives the contents of the body as a stream</param>
        /// <param name="context">The optional call context to use</param>
        /// <exception cref="CommunicationException"> when an exception occurred communicating with the Ingenico ePayments platform</exception>
        /// <exception cref="ResponseException">when an error response was received from the Ingenico ePayments platform</exception>
        /// <exception cref="ApiException">when an error response was received from the Ingenico ePayments platform which contained a list of errors</exception>
        /// <exception cref="BodyHandlerException">when the BodyHandler throws an exception</exception>
        public async Task Get(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                              Action<Stream, IEnumerable<IResponseHeader>> bodyHandler, CallContext context)
        {
            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();
            requestHeaders = AddGenericHeaders(HttpMethod.Get, uri, requestHeaders, context);
            await connection.Get(uri, requestHeaders, (status, body, headers) => {
                return ProcessResponse<object>(status, body, headers, relativePath, context, bodyHandler);
            });
        }

        /// <summary>
        /// Corresponds to the HTTP DELETE method.
        /// </summary>
        /// <param name="relativePath">The path to call, relative to the base URI.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="requestParameters">The optional set of request parameters.</param>
        /// <param name="context">The optional call context to use</param>
        /// <typeparam name="T">Type of the response.</typeparam>
        /// <exception cref="CommunicationException"> when an exception occurred communicating with the Ingenico ePayments platform</exception>
        /// <exception cref="ResponseException">when an error response was received from the Ingenico ePayments platform</exception>
        /// <exception cref="ApiException">when an error response was received from the Ingenico ePayments platform which contained a list of errors</exception>
        public async Task<T> Delete<T>(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                                       CallContext context)
        {
            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();
            requestHeaders = AddGenericHeaders(HttpMethod.Delete, uri, requestHeaders, context);
            return await connection.Delete<T>(uri, requestHeaders, (status, body, headers) => {
                return ProcessResponse<T>(status, body, headers, relativePath, context);
            });
        }

        /// <summary>
        /// Corresponds to the HTTP DELETE method.
        /// </summary>
        /// <param name="relativePath">The path to call, relative to the base URI.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="requestParameters">The optional set of request parameters.</param>
        /// <param name="bodyHandler">A callback that receives the contents of the body as a stream</param>
        /// <param name="context">The optional call context to use</param>
        /// <exception cref="CommunicationException"> when an exception occurred communicating with the Ingenico ePayments platform</exception>
        /// <exception cref="ResponseException">when an error response was received from the Ingenico ePayments platform</exception>
        /// <exception cref="ApiException">when an error response was received from the Ingenico ePayments platform which contained a list of errors</exception>
        /// <exception cref="BodyHandlerException">when the BodyHandler throws an exception</exception>
        public async Task Delete(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                                 Action<Stream, IEnumerable<IResponseHeader>> bodyHandler, CallContext context)
        {
            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();
            requestHeaders = AddGenericHeaders(HttpMethod.Delete, uri, requestHeaders, context);
            await connection.Delete(uri, requestHeaders, (status, body, headers) => {
                return ProcessResponse<object>(status, body, headers, relativePath, context, bodyHandler);
            });
        }

        /// <summary>
        /// Corresponds to the HTTP POST method.
        /// </summary>
        /// <param name="relativePath">The path to call, relative to the base URI.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="requestParameters">The optional set of request parameters.</param>
        /// <param name="requestBody">The optional request body to send.</param>
        /// <param name="context">The optional call context to use</param>
        /// <typeparam name="T">Type of the response.</typeparam>
        /// <exception cref="CommunicationException"> when an exception occurred communicating with the Ingenico ePayments platform</exception>
        /// <exception cref="ResponseException">when an error response was received from the Ingenico ePayments platform</exception>
        /// <exception cref="ApiException">when an error response was received from the Ingenico ePayments platform which contained a list of errors</exception>
        public async Task<T> Post<T>(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                                     object requestBody, CallContext context)
        {
            if (requestBody is MultipartFormDataObject)
            {
                return await Post<T>(relativePath, requestHeaders, requestParameters, (MultipartFormDataObject)requestBody, context);
            }
            if (requestBody is IMultipartFormDataRequest)
            {
                MultipartFormDataObject multipart = ((IMultipartFormDataRequest)requestBody).ToMultipartFormDataObject();
                return await Post<T>(relativePath, requestHeaders, requestParameters, multipart, context);
            }

            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            string requestJson = null;
            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();
            if (requestBody != null)
            {
                requestHeaderList.Add(new EntityHeader("Content-Type", "application/json"));
                requestJson = Marshaller.Marshal(requestBody);
            }

            requestHeaders = AddGenericHeaders(HttpMethod.Post, uri, requestHeaderList, context);
            return await connection.Post<T>(uri, requestHeaders, requestJson, (status, body, headers) => {
                return ProcessResponse<T>(status, body, headers, relativePath, context);
            });
        }

        async Task<T> Post<T>(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                                     MultipartFormDataObject multipart, CallContext context)
        {
            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();

            requestHeaderList.Add(new EntityHeader("Content-Type", multipart.ContentType));

            requestHeaders = AddGenericHeaders(HttpMethod.Post, uri, requestHeaderList, context);
            return await connection.Post<T>(uri, requestHeaders, multipart, (status, body, headers) => {
                return ProcessResponse<T>(status, body, headers, relativePath, context);
            });
        }

        /// <summary>
        /// Corresponds to the HTTP POST method.
        /// </summary>
        /// <param name="relativePath">The path to call, relative to the base URI.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="requestParameters">The optional set of request parameters.</param>
        /// <param name="requestBody">The optional request body to send.</param>
        /// <param name="bodyHandler">A callback that receives the contents of the body as a stream</param>
        /// <param name="context">The optional call context to use</param>
        /// <exception cref="CommunicationException"> when an exception occurred communicating with the Ingenico ePayments platform</exception>
        /// <exception cref="ResponseException">when an error response was received from the Ingenico ePayments platform</exception>
        /// <exception cref="ApiException">when an error response was received from the Ingenico ePayments platform which contained a list of errors</exception>
        /// <exception cref="BodyHandlerException">when the BodyHandler throws an exception</exception>
        public async Task Post(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                               object requestBody, Action<Stream, IEnumerable<IResponseHeader>> bodyHandler, CallContext context)
        {
            if (requestBody is MultipartFormDataObject)
            {
                await Post(relativePath, requestHeaders, requestParameters, (MultipartFormDataObject)requestBody, bodyHandler, context);
                return;
            }
            if (requestBody is IMultipartFormDataRequest)
            {
                MultipartFormDataObject multipart = ((IMultipartFormDataRequest)requestBody).ToMultipartFormDataObject();
                await Post(relativePath, requestHeaders, requestParameters, multipart, bodyHandler, context);
                return;
            }

            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            string requestJson = null;
            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();
            if (requestBody != null)
            {
                requestHeaderList.Add(new EntityHeader("Content-Type", "application/json"));
                requestJson = Marshaller.Marshal(requestBody);
            }

            requestHeaders = AddGenericHeaders(HttpMethod.Post, uri, requestHeaderList, context);
            await connection.Post(uri, requestHeaders, requestJson, (status, body, headers) => {
                return ProcessResponse<object>(status, body, headers, relativePath, context, bodyHandler);
            });
        }

        async Task Post(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                               MultipartFormDataObject multipart, Action<Stream, IEnumerable<IResponseHeader>> bodyHandler, CallContext context)
        {
            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();

            requestHeaderList.Add(new EntityHeader("Content-Type", multipart.ContentType));

            requestHeaders = AddGenericHeaders(HttpMethod.Post, uri, requestHeaderList, context);
            await connection.Post(uri, requestHeaders, multipart, (status, body, headers) => {
                return ProcessResponse<object>(status, body, headers, relativePath, context, bodyHandler);
            });
        }

        /// <summary>
        /// Corresponds to the HTTP PUT method.
        /// </summary>
        /// <param name="relativePath">The path to call, relative to the base URI.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="requestParameters">The optional set of request parameters.</param>
        /// <param name="requestBody">The optional request body to send.</param>
        /// <param name="context">The optional call context to use</param>
        /// <typeparam name="T">Type of the response.</typeparam>
        /// <exception cref="CommunicationException"> when an exception occurred communicating with the Ingenico ePayments platform</exception>
        /// <exception cref="ResponseException">when an error response was received from the Ingenico ePayments platform</exception>
        /// <exception cref="ApiException">when an error response was received from the Ingenico ePayments platform which contained a list of errors</exception>
        public async Task<T> Put<T>(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                                    object requestBody, CallContext context)
        {
            if (requestBody is MultipartFormDataObject)
            {
                return await Put<T>(relativePath, requestHeaders, requestParameters, (MultipartFormDataObject)requestBody, context);
            }
            if (requestBody is IMultipartFormDataRequest)
            {
                MultipartFormDataObject multipart = ((IMultipartFormDataRequest)requestBody).ToMultipartFormDataObject();
                return await Put<T>(relativePath, requestHeaders, requestParameters, multipart, context);
            }

            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            string requestJson = null;
            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();
            if (requestBody != null)
            {
                requestHeaderList.Add(new EntityHeader("Content-Type", "application/json"));
                requestJson = Marshaller.Marshal(requestBody);
            }

            requestHeaders = AddGenericHeaders(HttpMethod.Put, uri, requestHeaderList, context);
            return await connection.Put<T>(uri, requestHeaders, requestJson, (status, body, headers) => {
                return ProcessResponse<T>(status, body, headers, relativePath, context);
            });
        }

        async Task<T> Put<T>(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                                    MultipartFormDataObject multipart, CallContext context)
        {
            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();

            requestHeaderList.Add(new EntityHeader("Content-Type", multipart.ContentType));

            requestHeaders = AddGenericHeaders(HttpMethod.Put, uri, requestHeaderList, context);
            return await connection.Put<T>(uri, requestHeaders, multipart, (status, body, headers) => {
                return ProcessResponse<T>(status, body, headers, relativePath, context);
            });
        }

        /// <summary>
        /// Corresponds to the HTTP PUT method.
        /// </summary>
        /// <param name="relativePath">The path to call, relative to the base URI.</param>
        /// <param name="requestHeaders">An optional list of request headers.</param>
        /// <param name="requestParameters">The optional set of request parameters.</param>
        /// <param name="requestBody">The optional request body to send.</param>
        /// <param name="bodyHandler">A callback that receives the contents of the body as a stream</param>
        /// <param name="context">The optional call context to use</param>
        /// <exception cref="CommunicationException"> when an exception occurred communicating with the Ingenico ePayments platform</exception>
        /// <exception cref="ResponseException">when an error response was received from the Ingenico ePayments platform</exception>
        /// <exception cref="ApiException">when an error response was received from the Ingenico ePayments platform which contained a list of errors</exception>
        /// <exception cref="BodyHandlerException">when the BodyHandler throws an exception</exception>
        public async Task Put(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                              object requestBody, Action<Stream, IEnumerable<IResponseHeader>> bodyHandler, CallContext context)
        {
            if (requestBody is MultipartFormDataObject)
            {
                await Put(relativePath, requestHeaders, requestParameters, (MultipartFormDataObject)requestBody, bodyHandler, context);
                return;
            }
            if (requestBody is IMultipartFormDataRequest)
            {
                MultipartFormDataObject multipart = ((IMultipartFormDataRequest)requestBody).ToMultipartFormDataObject();
                await Put(relativePath, requestHeaders, requestParameters, multipart, bodyHandler, context);
                return;
            }

            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            string requestJson = null;
            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();
            if (requestBody != null)
            {
                requestHeaderList.Add(new EntityHeader("Content-Type", "application/json"));
                requestJson = Marshaller.Marshal(requestBody);
            }

            requestHeaders = AddGenericHeaders(HttpMethod.Put, uri, requestHeaderList, context);
            await connection.Put(uri, requestHeaders, requestJson, (status, body, headers) => {
                return ProcessResponse<object>(status, body, headers, relativePath, context, bodyHandler);
            });
        }

        async Task Put(string relativePath, IEnumerable<IRequestHeader> requestHeaders, AbstractParamRequest requestParameters,
                              MultipartFormDataObject multipart, Action<Stream, IEnumerable<IResponseHeader>> bodyHandler, CallContext context)
        {
            IConnection connection = Session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();

            requestHeaderList.Add(new EntityHeader("Content-Type", multipart.ContentType));

            requestHeaders = AddGenericHeaders(HttpMethod.Put, uri, requestHeaderList, context);
            await connection.Put(uri, requestHeaders, multipart, (status, body, headers) => {
                return ProcessResponse<object>(status, body, headers, relativePath, context, bodyHandler);
            });
        }
        #endregion

        /// <summary>
        /// Utility method that delegates the call to this communicator's session's connection if that's an instance of <see cref="IPooledConnection"/>. 
        /// If not this method does nothing.
        /// <seealso cref="IPooledConnection.CloseExpiredConnections"/> 
        /// </summary>
        public void CloseExpiredConnections()
        {
            IConnection connection = Session.Connection;
            if (typeof(IPooledConnection).IsAssignableFrom(connection.GetType()))
            {
                ((IPooledConnection)connection).CloseExpiredConnections();
            }
        }

        /// <summary>
        /// Utility method that delegates the call to this communicator's session's connection if that's an instance of
        /// <see cref="IPooledConnection"/>.
        /// </summary>
        /// <param name="timespan">Idle time.</param>
        public void CloseIdleConnections(TimeSpan timespan)
        {
            IConnection connection = Session.Connection;
            if (connection is IPooledConnection)
            {
                ((IPooledConnection)connection).CloseIdleConnections(timespan);
            }
        }

        internal Session Session { get; }

        internal Uri ToAbsoluteURI(string relativePath, IEnumerable<RequestParam> requestParameters)
        {

            Uri apiEndpoint = Session.ApiEndpoint;

            if (apiEndpoint.HasPath())
            {
                throw new InvalidOperationException("apiEndpoint should not contain a path");
            }
            if (apiEndpoint.HasUserInfoOrQueryOrFragment())
            {
                throw new InvalidOperationException("apiEndpoint should not contain user info, query or fragment");
            }

            string absolutePath;
            if (relativePath.StartsWith("/", StringComparison.Ordinal))
            {
                absolutePath = relativePath;
            }
            else
            {
                absolutePath = "/" + relativePath;
            }

            UriBuilder uriBuilder = new UriBuilder
            {
                Scheme = apiEndpoint.Scheme,
                Host = apiEndpoint.Host,
                Port = apiEndpoint.Port,
                Path = absolutePath,
            };

            if (requestParameters != null)
            {
                foreach (RequestParam nvp in requestParameters)
                {
                    uriBuilder.AddParameter(nvp.Name, nvp.Value);
                }
            }

            return uriBuilder.Uri;
        }

        /// <summary>
        /// Adds the necessary headers to the given list of headers. This includes the authorization header, 
        /// which uses other headers, so when you need to override this method, 
        /// make sure to call <code>base.AddGenericHeaders</code> at the <i>end</i> of your overridden method.
        /// </summary>
        protected IEnumerable<IRequestHeader> AddGenericHeaders(HttpMethod httpMethod, Uri uri, IEnumerable<IRequestHeader> requestHeaders, CallContext context)
        {
            var requestHeaderList = requestHeaders.ToList();

            // add server meta info headers
            requestHeaderList.AddRange(Session.MetaDataProvider.ServerMetaDataHeaders);

            // add date header
            requestHeaderList.Add(new RequestHeader("Date", GetHeaderDateString()));

            // add context specific headers
            if (context != null && context.IdempotenceKey != null)
            {
                requestHeaderList.Add(new RequestHeader("X-GCS-Idempotence-Key", context.IdempotenceKey));
            }

            // add signature
            IAuthenticator authenticator = Session.Authenticator;
            string authenticationSignature = authenticator.CreateSimpleAuthenticationSignature(httpMethod, uri, requestHeaderList);
            requestHeaderList.Add(new RequestHeader("Authorization", authenticationSignature));
            return requestHeaderList;
        }

        /// <summary>
        /// Gets the date in the preferred format for the HTTP date header (RFC1123).
        /// </summary>
        /// <returns>The header date string.</returns>
        protected string GetHeaderDateString()
        {
            return DateTime.UtcNow.ToString("r");
        }

        /// <summary>
        /// Checks the response for errors and throws an exception if necessary.
        /// </summary>
        protected void ThrowExceptionIfNecessary(HttpStatusCode statusCode, Stream stream, IEnumerable<IResponseHeader> headers, string requestPath)
        {
            int intStatusCode = (int)statusCode;
            // status codes in the 100 or 300 range are not expected
            if (intStatusCode < 200 || intStatusCode >= 300)
            {
                var sr = new StreamReader(stream);
                string body = sr.ReadToEnd();

                if (body.IsNullOrEmpty() || !IsJson(headers))
                {
                    ResponseException cause = new ResponseException(statusCode, body, headers);
                    if (intStatusCode == (int)HttpStatusCode.NotFound)
                    {
                        throw new NotFoundException("The requested resource was not found; invalid path: " + requestPath, cause);
                    }
                    throw new CommunicationException(cause);
                }
                throw new ResponseException(statusCode, body, headers);
            }
        }

        protected O ProcessResponse<O>(HttpStatusCode statusCode, Stream stream, IEnumerable<IResponseHeader> headers, string requestPath, CallContext context, Action<Stream, IEnumerable<IResponseHeader>> bodyHandler = null)
        {
            if (context != null)
            {
                context.IdempotenceRequestTimestamp = GetIdempotenceTimestamp(headers);
            }
            ThrowExceptionIfNecessary(statusCode, stream, headers, requestPath);
            if (bodyHandler == null) {
                return Marshaller.Unmarshal<O>(stream);
            }
            try
            {
                bodyHandler(stream, headers);
            }
            catch (Exception e)
            {
                throw new BodyHandlerException("The bodyhandler threw an exception", e);
            }
            return default;

        }

        protected long? GetIdempotenceTimestamp(IEnumerable<IResponseHeader> headers)
        {
            if (long.TryParse(headers?.GetHeaderValue("X-GCS-Idempotence-Request-Timestamp"), out long retValue))
            {
                return retValue;
            }
            return null;
        }

        bool IsJson(IEnumerable<IResponseHeader> headers)
        {
            string contentType = headers?.GetHeaderValue("Content-Type")?.ToLower();
            return contentType == null || "application/json".Equals(contentType) || contentType.StartsWith("application/json", StringComparison.Ordinal);
        }
    }
}
