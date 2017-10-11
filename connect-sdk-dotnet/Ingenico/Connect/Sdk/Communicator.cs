using System;
using System.Collections.Generic;
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
        public IMarshaller Marshaller => _marshaller;
        readonly IMarshaller _marshaller;

        public Communicator(Session session, IMarshaller marshaller)
        {
            if (session == null)
            {
                throw new ArgumentException("session is required");
            }
            if (marshaller == null)
            {
                throw new ArgumentException("marshaller is required");
            }
            _session = session;
            _marshaller = marshaller;
        }

        #region IDisposable implementation
        public void Dispose()
        {
            _session.Connection.Dispose();
        }
        #endregion

        #region ILoggingCapable implementation
        public void EnableLogging(ICommunicatorLogger communicatorLogger)
        {
            _session.Connection.EnableLogging(communicatorLogger);
        }

        public void DisableLogging()
        {
            _session.Connection.DisableLogging();
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
            IConnection connection = _session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();
            requestHeaders = AddGenericHeaders(HttpMethod.Get, uri, requestHeaders, context);
            Response response = await connection.Get(uri, requestHeaders);
            return ProcessResponse<T>(response, relativePath, context);
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
            IConnection connection = _session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();
            requestHeaders = AddGenericHeaders(HttpMethod.Delete, uri, requestHeaders, context);
            Response response = await connection.Delete(uri, requestHeaders);
            return ProcessResponse<T>(response, relativePath, context);
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
            IConnection connection = _session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            string requestJson = null;
            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();
            if (requestBody != null)
            {
                requestHeaderList.Add(new EntityHeader("Content-Type", "application/json"));
                requestJson = _marshaller.Marshal(requestBody);
            }

            requestHeaders = AddGenericHeaders(HttpMethod.Post, uri, requestHeaderList, context);
            Response response = await connection.Post(uri, requestHeaders, requestJson);
            return ProcessResponse<T>(response, relativePath, context);
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
            IConnection connection = _session.Connection;
            IEnumerable<RequestParam> requestParameterList = requestParameters?.ToRequestParameters();
            Uri uri = ToAbsoluteURI(relativePath, requestParameterList);
            requestHeaders = requestHeaders ?? new List<IRequestHeader>();

            string requestJson = null;
            IList<IRequestHeader> requestHeaderList = requestHeaders.ToList();
            if (requestBody != null)
            {
                requestHeaderList.Add(new EntityHeader("Content-Type", "application/json"));
                requestJson = _marshaller.Marshal(requestBody);
            }

            requestHeaders = AddGenericHeaders(HttpMethod.Put, uri, requestHeaderList, context);
            Response response = await connection.Post(uri, requestHeaders, requestJson);
            return ProcessResponse<T>(response, relativePath, context);
        }
        #endregion

        /// <summary>
        /// Utility method that delegates the call to this communicator's session's connection if that's an instance of <see cref="IPooledConnection"/>. 
        /// If not this method does nothing.
        /// <seealso cref="IPooledConnection.CloseExpiredConnections"/> 
        /// </summary>
        public void CloseExpiredConnections()
        {
            IConnection connection = _session.Connection;
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
            IConnection connection = _session.Connection;
            if (connection is IPooledConnection)
            {
                ((IPooledConnection)connection).CloseIdleConnections(timespan);
            }
        }

        internal Session Session => _session;

        internal Uri ToAbsoluteURI(string relativePath, IEnumerable<RequestParam> requestParameters)
        {

            Uri apiEndpoint = _session.ApiEndpoint;

            if (apiEndpoint.LocalPath != null && !apiEndpoint.LocalPath.Equals("/"))
            {
                throw new InvalidOperationException("apiEndpoint should not contain a path");
            }
            if (apiEndpoint.UserInfo != "" || apiEndpoint.Query != "" || apiEndpoint.Fragment != "")
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

            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = apiEndpoint.Scheme;
            uriBuilder.Host = apiEndpoint.Host;
            uriBuilder.Port = apiEndpoint.Port;
            uriBuilder.Path = absolutePath;

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
            requestHeaderList.AddRange(_session.MetaDataProvider.ServerMetaDataHeaders);

            // add date header
            requestHeaderList.Add(new RequestHeader("Date", GetHeaderDateString()));

            // add context specific headers
            if (context != null && context.IdempotenceKey != null)
            {
                requestHeaderList.Add(new RequestHeader("X-GCS-Idempotence-Key", context.IdempotenceKey));
            }

            // add signature
            IAuthenticator authenticator = _session.Authenticator;
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
        /// Checks the <see cref="Response"/> for errors and throws an exception if necessary.
        /// </summary>
        protected void ThrowExceptionIfNecessary(Response response, string requestPath)
        {
            int statusCode = (int)response.StatusCode;
            // status codes in the 100 or 300 range are not expected
            if (statusCode < 200 || statusCode >= 300)
            {
                string body = response.Body;
                if (body != null && !IsJson(response))
                {
                    ResponseException cause = new ResponseException(response);
                    if (statusCode == (int)HttpStatusCode.NotFound)
                    {
                        throw new NotFoundException("The requested resource was not found; invalid path: " + requestPath, cause);
                    }
                    throw new CommunicationException(cause);
                }
                throw new ResponseException(response);
            }
        }

        protected O ProcessResponse<O>(Response response, string requestPath, CallContext context)
        {
            if (context != null)
            {
                context.IdempotenceRequestTimestamp = GetIdempotenceTimestamp(response);
            }
            ThrowExceptionIfNecessary(response, requestPath);
            return _marshaller.Unmarshal<O>(response.Body);
        }

        protected long? GetIdempotenceTimestamp(Response response)
        {
            long retValue;
            if (long.TryParse(response.GetHeaderValue("X-GCS-Idempotence-Request-Timestamp"), out retValue))
            {
                return retValue;
            }
            return null;
        }

        readonly Session _session;

        bool IsJson(Response response)
        {
            string contentType = response.GetHeaderValue("Content-Type")?.ToLower();
            return contentType == null || "application/json".Equals(contentType) || contentType.StartsWith("application/json", StringComparison.Ordinal);
        }
    }
}
