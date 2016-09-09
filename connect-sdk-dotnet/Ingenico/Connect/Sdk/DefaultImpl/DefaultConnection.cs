using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Ingenico.Connect.Sdk.Logging;

namespace Ingenico.Connect.Sdk.DefaultImpl
{
    /// <summary>
    /// The default implementation for the connection interface. Supports Pooling, and is thread safe.
    /// </summary>
    public class DefaultConnection : IPooledConnection
    {
        public DefaultConnection(TimeSpan? socketTimeout, int maxConnections = 2, Proxy proxy = null)
        {
            var handler = new HttpClientHandler();
            if (proxy != null)
            {
                handler.Proxy = new WebProxy(proxy.Uri);
                if (proxy.Username != null)
                {
                    handler.Proxy.Credentials = new NetworkCredential(proxy.Username, proxy.Password);
                }

                handler.UseProxy = true;
            }

            ServicePointManager.DefaultConnectionLimit = maxConnections;
            _httpClient = new HttpClient(handler);
            if (socketTimeout != null)
            {
                _httpClient.Timeout = socketTimeout.Value;
            }
        }

        internal DefaultConnection(TimeSpan? socketTimeout,ProxyConfiguration proxyConfig, int maxConnections = 2)
        {
            var handler = new HttpClientHandler();
            if (proxyConfig != null)
            {
                handler.Proxy = new WebProxy(proxyConfig.Uri);
                if (proxyConfig.Username != null)
                {
                    handler.Proxy.Credentials = new NetworkCredential(proxyConfig.Username, proxyConfig.Password);
                }

                handler.UseProxy = true;
            }

            ServicePointManager.DefaultConnectionLimit = maxConnections;
            _httpClient = new HttpClient(handler);
            if (socketTimeout != null)
            {
                _httpClient.Timeout = socketTimeout.Value;
            }
        }

        async Task<Response> SendHttpMessage(HttpMethod method, Uri uri, IEnumerable<IRequestHeader> requestHeaders, string body = null)
        {
            var guid = Guid.NewGuid();
            try
            {
                using (var message = new HttpRequestMessage(method, uri))
                using (var content = (body == null ? null : new StringContent(body)))
                {
                    if (content != null)
                    {
                        message.Content = content;
                    }
                    foreach (var a in requestHeaders)
                    {
                        if (a is EntityHeader)
                        {
                            if (content != null)
                            {
                                message.Content.Headers.Remove(a.Name);
                                message.Content.Headers.Add(a.Name, a.Value);
                            }
                        }
                        else {
                            message.Headers.Add(a.Name, a.Value);
                        }
                    }
                    var startTime = DateTime.Now;
                    LogRequest(guid, message, content, body);
                    var httpResponseTask = _httpClient.SendAsync(message);
                    var httpResponse = await httpResponseTask;
                    var responseBodyTask = httpResponse.Content.ReadAsStringAsync();
                    var headers = from header in httpResponse.Headers
                                  from value in header.Value
                                  select new ResponseHeader(header.Key, value);
                    var responseBody = await responseBodyTask;
                    var endTime = DateTime.Now;
                    var duration = endTime - startTime;
                    LogResponse(guid, uri, httpResponse, httpResponse.Content.Headers, responseBody, duration);
                    var responseBodyHeaders = from header in httpResponse.Content.Headers
                                              from aValue in header.Value
                                              select new EntityHeader(header.Key, aValue);
                    return new Response(httpResponse.StatusCode, responseBody, headers.Cast<IResponseHeader>().Union(responseBodyHeaders));

                }
            }
            catch (HttpRequestException exception)
            {
                LogException(guid, exception);
                throw new CommunicationException(exception);
            }
            catch (TaskCanceledException exception)
            {
                LogException(guid, exception);
                throw new CommunicationException(exception);
            }
            catch (WebException exception)
            {
                LogException(guid, exception);
                throw new CommunicationException(exception);
            }

        }

        #region IPooledConnection implementation
        public void CloseIdleConnections(TimeSpan timespan)
        {
            // Done automatically so this is a No-Op
        }

        public void CloseExpiredConnections()
        {
            // Done automatically so this is a No-Op
        }
        #endregion

        #region IConnection implementation
        public async Task<Response> Get(Uri uri, IEnumerable<IRequestHeader> requestHeaders)
        {
            return await SendHttpMessage(HttpMethod.Get, uri, requestHeaders);
        }

        public async Task<Response> Delete(Uri uri, IEnumerable<IRequestHeader> requestHeaders)
        {
            return await SendHttpMessage(HttpMethod.Delete, uri, requestHeaders);
        }

        public async Task<Response> Post(Uri uri, IEnumerable<IRequestHeader> requestHeaders, string body)
        {
            return await SendHttpMessage(HttpMethod.Post, uri, requestHeaders, body);
        }

        public async Task<Response> Put(Uri uri, IEnumerable<IRequestHeader> requestHeaders, string body)
        {
            return await SendHttpMessage(HttpMethod.Put, uri, requestHeaders, body);

        }
        #endregion

        #region ILoggingCapable implementation
        public void EnableLogging(ICommunicatorLogger communicatorLogger)
        {
            _communicatorLogger = communicatorLogger;
        }

        public void DisableLogging()
        {
            _communicatorLogger = null;
        }
        #endregion

        #region IDisposable implementation
        public void Dispose()
        {
            _httpClient.Dispose();
        }
        #endregion

        #region Logging
        void LogRequest(Guid guid, HttpRequestMessage message, HttpContent body, string bodyContent)
        {
            var sb = new RequestLogMessageBuilder(guid.ToString(), message.Method.ToString(), message.RequestUri.PathAndQuery);
            foreach (var header in message.Headers)
            {
                sb.AddHeader(header.Key, string.Join(" ", header.Value));
            }
            if (bodyContent != null && body != null)
            {
                foreach (var header in body?.Headers)
                {
                    sb.AddHeader(header.Key, string.Join(" ", header.Value));
                }
                sb.SetBody(bodyContent, body.Headers?.ContentType.ToString());
            }
            _communicatorLogger?.Log(sb.Message);
        }

        void LogResponse(Guid guid, Uri uri, HttpResponseMessage httpResponse, HttpContentHeaders responseBodyHeaders, string responseBody, TimeSpan duration)
        {
            var sb = new ResponseLogMessageBuilder(guid.ToString(), httpResponse.StatusCode);
            sb.Duration = duration;
            foreach (var header in httpResponse.Headers)
            {
                sb.AddHeader(header.Key, string.Join(" ", header.Value));
            }
            if (responseBodyHeaders != null)
            {
                foreach (var header in responseBodyHeaders)
                {
                    sb.AddHeader(header.Key, string.Join(" ", header.Value));
                }
            }
            if (responseBody != "")
            {
                sb.SetBody(responseBody, responseBodyHeaders.ContentType.ToString());
            }
            _communicatorLogger?.Log(sb.Message);
        }

        void LogException(Guid guid, Exception exception)
        {
            _communicatorLogger?.Log("Error occurred for outgoing request (requestId='" + guid + "')", exception);
        }
        #endregion

        // Private because not all operations are guaranteed to be thread safe. 
        // This class only uses thread safe methods (except in the constructor)
        HttpClient _httpClient;

        ICommunicatorLogger _communicatorLogger;
    }
}
