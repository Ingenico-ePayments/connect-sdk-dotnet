using NUnit.Framework;
using System;
using System.Collections.Generic;
using Ingenico.Connect.Sdk.DefaultImpl;

namespace Ingenico.Connect.Sdk
{
    [TestFixture]
    public class CommunitatorConfigurationTest
    {
        const string AuthType = "v1HMAC";

        [TestCase]
        public void TestConstructFromPropertiesWithoutProxy()
        {
            CommunicatorConfiguration configuration = CreateBasicConfiguration();

            AssertBasicConfigurationSettings(configuration);
            Assert.AreEqual(CommunicatorConfiguration.DefaultMaxConnections, configuration.MaxConnections);
            Assert.Null(configuration.ApiKeyId);
            Assert.Null(configuration.SecretApiKey);

            // In original tests was null, but not anymore, because of app config configuration
            //Assert.Null(configuration.ProxyConfiguration);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithProxyWithoutAuthentication()
        {
            CommunicatorConfiguration configuration =
                CreateBasicConfiguration()
                                          .WithProxyUri(new Uri("http://proxy.example.org:3128"));

            AssertBasicConfigurationSettings(configuration);
            Assert.AreEqual(CommunicatorConfiguration.DefaultMaxConnections, configuration.MaxConnections);
            Assert.Null(configuration.ApiKeyId);
            Assert.Null(configuration.SecretApiKey);

            Assert.NotNull(configuration.ProxyConfiguration);
            ProxyConfiguration proxyFig = configuration.ProxyConfiguration;
            AssertBasicProxySettings(proxyFig);
            Assert.That(proxyFig.Username, Is.Empty);
            Assert.That(proxyFig.Password, Is.Empty);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithProxyWithAuthentication()
        {
            CommunicatorConfiguration configuration = CreateBasicConfiguration()
                                                   .WithProxyUri(new Uri("http://proxy.example.org:3128"))
                                                   .WithProxyUserName("connect-username")
                                                   .WithProxyPassword("connect-password");

            AssertBasicConfigurationSettings(configuration);
            Assert.AreEqual(CommunicatorConfiguration.DefaultMaxConnections, configuration.MaxConnections);
            Assert.Null(configuration.ApiKeyId);
            Assert.Null(configuration.SecretApiKey);

            Assert.NotNull(configuration.ProxyConfiguration);
            ProxyConfiguration proxyFig = configuration.ProxyConfiguration;
            AssertBasicProxySettings(proxyFig);
            Assert.AreEqual("connect-username", proxyFig.Username);
            Assert.AreEqual("connect-password", proxyFig.Password);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithMaxConnections()
        {
            CommunicatorConfiguration configuration = CreateBasicConfiguration()
                                                            .WithMaxConnections(100);

            AssertBasicConfigurationSettings(configuration);
            Assert.AreEqual(100, configuration.MaxConnections);
            Assert.Null(configuration.ApiKeyId);
            Assert.Null(configuration.SecretApiKey);

            // In original tests was null, but not anymore, because of app config configuration
            //Assert.Null(configuration.ProxyConfiguration);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithHostAndScheme()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties["connect.api.endpoint.scheme"] = "http";
            properties["connect.api.endpoint.host"] = "api-sandbox.globalcollect.com";
            properties["connect.api.authorizationType"] = AuthType;
            properties["connect.api.connectTimeout"] = "20000";
            properties["connect.api.socketTimeout"] = "10000";

            CommunicatorConfiguration configuration = new CommunicatorConfiguration(properties);

            Assert.AreEqual(new Uri("http://api-sandbox.globalcollect.com"), configuration.ApiEndpoint);

        }

        [TestCase]
        public void TestConstructFromPropertiesWithHostAndPort()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties["connect.api.endpoint.port"] = "8443";
            properties["connect.api.endpoint.host"] = "api-sandbox.globalcollect.com";
            properties["connect.api.authorizationType"] = AuthType;
            properties["connect.api.connectTimeout"] = "20000";
            properties["connect.api.socketTimeout"] = "10000";

            CommunicatorConfiguration configuration = new CommunicatorConfiguration(properties);

            Assert.AreEqual(new Uri("https://api-sandbox.globalcollect.com:8443"), configuration.ApiEndpoint);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithHostSchemeAndPort()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties["connect.api.endpoint.port"] = "8080";
            properties["connect.api.endpoint.host"] = "api-sandbox.globalcollect.com";
            properties["connect.api.endpoint.scheme"] = "http";
            properties["connect.api.authorizationType"] = AuthType;
            properties["connect.api.connectTimeout"] = "20000";
            properties["connect.api.socketTimeout"] = "10000";

            CommunicatorConfiguration configuration = new CommunicatorConfiguration(properties);

            Assert.AreEqual(new Uri("http://api-sandbox.globalcollect.com:8080"), configuration.ApiEndpoint);
        }

        [TestCase]
        public void TestConstructFromPropertiesWithIPv6Host()
        {
            Dictionary<string, string> properties = new Dictionary<string, string>();
            properties["connect.api.endpoint.host"] = "::1";
            properties["connect.api.authorizationType"] = AuthType;
            properties["connect.api.connectTimeout"] = "20000";
            properties["connect.api.socketTimeout"] = "10000";

            CommunicatorConfiguration configuration = new CommunicatorConfiguration(properties);

            Assert.AreEqual(new Uri("https://[::1]"), configuration.ApiEndpoint);
        }

        CommunicatorConfiguration CreateBasicConfiguration()
        {
            return new CommunicatorConfiguration()
                                                  .WithApiEndpoint(new Uri("https://api-sandbox.globalcollect.com"))
                                                  .WithAuthorizationType(AuthorizationType.V1HMAC)
                                                  .WithConnectTimeout(20000)
                                                  .WithSocketTimeout(10000);
        }

        void AssertBasicConfigurationSettings(CommunicatorConfiguration configuration)
        {
            Assert.AreEqual(new Uri("https://api-sandbox.globalcollect.com"), configuration.ApiEndpoint);
            Assert.AreEqual(AuthorizationType.V1HMAC, configuration.AuthorizationType);
            Assert.AreEqual(20000, configuration.ConnectTimeout?.TotalMilliseconds);
            Assert.AreEqual(10000, configuration.SocketTimeout?.TotalMilliseconds);
        }

        /// <summary>
        /// Checks validity of basic proxy settings of a proxy with uri http://proxy.example.org:3128.
        /// </summary>
        /// <param name="proxyFig">Proxy fig.</param>
        void AssertBasicProxySettings(ProxyConfiguration proxyFig)
        {
            Assert.AreEqual("http", proxyFig.Scheme);
            Assert.AreEqual("proxy.example.org", proxyFig.Host);
            Assert.AreEqual(3128, proxyFig.Port);
        }
    }
}

