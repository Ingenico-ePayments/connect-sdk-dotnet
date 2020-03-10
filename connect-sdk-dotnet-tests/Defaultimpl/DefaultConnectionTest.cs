using NUnit.Framework;
using System;
using System.Net.Http;
using Ingenico.Connect.Sdk.Util;
using System.Net;

namespace Ingenico.Connect.Sdk.DefaultImpl
{
    [TestFixture]
    public class DefaultConnectionTest
    {
        static readonly TimeSpan SOCKET_TIMEOUT = TimeSpan.FromMilliseconds(10000);
        const int MAX_CONNECTIONS = 100;

        [TestCase]
        public void TestConstructWithoutProxy()
        {
            DefaultConnection connection = new DefaultConnection(SOCKET_TIMEOUT, MAX_CONNECTIONS);
            //assertMaxConnections(connection, CommunicatorConfiguration.DEFAULT_MAX_CONNECTIONS, null);
            AssertConnectTimeout(connection);
            AssertNoProxy(connection);
            // TODO: check max connections

        }

        static void AssertConnectTimeout(DefaultConnection connection)
        {
            HttpClient httpClient = (HttpClient)connection.GetPrivateField("_httpClient");
            Assert.AreEqual(httpClient.Timeout, SOCKET_TIMEOUT);
        }

        static void AssertNoProxy(DefaultConnection connection)
        {
            HttpClient httpClient = (HttpClient)connection.GetPrivateField("_httpClient");
            HttpClientHandler handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("handler");
            if (handler == null)
            {
                handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("_handler");
            }
            Assert.Null(handler.Proxy);
        }

        static void AssertProxy(DefaultConnection connection, Proxy proxy)
        {
            HttpClient httpClient = (HttpClient)connection.GetPrivateField("_httpClient");
            HttpClientHandler handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("handler");
            if (handler == null)
            {
                handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("_handler");
            }
            Assert.That(handler.UseProxy, Is.True);
            Assert.That(((WebProxy)handler.Proxy).Address, Is.EqualTo(proxy.Uri));
            Assert.That(((NetworkCredential)handler.Proxy.Credentials), Is.Null);
        }

        void AssertProxyAndAuthentication(DefaultConnection connection, Proxy proxy)
        {
            HttpClient httpClient = (HttpClient)connection.GetPrivateField("_httpClient");
            HttpClientHandler handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("handler");
            if (handler == null)
            {
                handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("_handler");
            }
            Assert.That(handler.UseProxy, Is.True);
            Assert.That(((WebProxy)handler.Proxy).Address, Is.EqualTo(proxy.Uri));
            Assert.That(((NetworkCredential)handler.Proxy.Credentials), Is.Not.Null);
            Assert.That(((NetworkCredential)handler.Proxy.Credentials).UserName, Is.EqualTo(proxy.Username));
            Assert.That(((NetworkCredential)handler.Proxy.Credentials).Password, Is.EqualTo(proxy.Password));
        }

        [TestCase]
        public void TestConstructWithProxyWithoutAuthentication()
        {
            var proxy = new Proxy { Uri = new Uri("http://test-proxy")};

            DefaultConnection connection = new DefaultConnection(SOCKET_TIMEOUT, MAX_CONNECTIONS, proxy);
            AssertConnectTimeout(connection);
            //assertMaxConnections(connection, CommunicatorConfiguration.DEFAULT_MAX_CONNECTIONS, proxyConfiguration);
            AssertProxy(connection, proxy);
        }

        [TestCase]
        public void TestConstructWithProxyWithAuthentication()
        {
            var proxy = new Proxy { Uri = new Uri("http://test-proxy") , Username = "test-username", Password = "test-password" };

            DefaultConnection connection = new DefaultConnection(SOCKET_TIMEOUT, MAX_CONNECTIONS, proxy);
            AssertConnectTimeout(connection);
            //assertMaxConnections(connection, CommunicatorConfiguration.DEFAULT_MAX_CONNECTIONS, proxyConfiguration);
            AssertProxyAndAuthentication(connection, proxy);
        }


        [TestCase, Ignore("Not implemented because max connections is not testable")]
        public void TestConstructWithMaxConnectionsWithoutProxy()
        {
            throw new NotImplementedException();
        }

        [TestCase, Ignore("Not implemented because max connections is not testable")]
        public void TestConstructWithMaxConnectionsWithProxy()
        {
            throw new NotImplementedException();
        }
    }
}
