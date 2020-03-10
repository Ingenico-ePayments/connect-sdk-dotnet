using System;
using System.Collections.Generic;
using Ingenico.Connect.Sdk.DefaultImpl;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Configuration for the communicator.
    /// </summary>
    public class CommunicatorConfiguration
    {
        CommunicatorConfigurationSection Section { get; set; } = new CommunicatorConfigurationSection();
        /// <summary>
        /// The default number of maximum connections
        /// </summary>
        public const int DefaultMaxConnections = 10;

        internal UriConfiguration ApiEndpointConfig
        {
            get
            {
                return Section.ApiEndpointConfig;
            }
        }

        /// <summary>
        /// Gets or sets the Ingenico ePayments platform API endpoint URI.
        /// </summary>
        public Uri ApiEndpoint
        {
            get
            {
                return Section.ApiEndpoint;
            }
            set
            {
                Section.ApiEndpoint = value;
            }
        }

        /// <summary>
        /// Gets or sets the connect timeout
        /// </summary>
        public TimeSpan? ConnectTimeout
        {
            get
            {
                return Section.ConnectTimeout;
            }
            set
            {
                Section.ConnectTimeout = value;
            }
        }

        /// <summary>
        /// Gets or sets the socket timeout
        /// </summary>
        public TimeSpan? SocketTimeout
        {
            get
            {
                return Section.SocketTimeout;
            }
            set
            {
                Section.SocketTimeout = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximal number of connections
        /// </summary>
        public int MaxConnections
        {
            get
            {
                return Section.MaxConnections;
            }
            set
            {
                Section.MaxConnections = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the authorization.
        /// </summary>
        public AuthorizationType AuthorizationType
        {
            get
            {
                return AuthorizationType.GetValueOf(Section.AuthorizationType);
            }
            set
            {
                Section.AuthorizationType = value.SignatureString;
            }
        }

        /// <summary>
        /// Gets or sets an identifier for the secret API key. The <code>apiKeyId</code> can be
        /// retrieved from the Configuration Center. This identifier is visible in
        /// the HTTP request and is also used to identify the correct account.
        /// </summary>
        public string ApiKeyId
        {
            get
            {
                return Section.ApiKeyId;
            }
            set
            {
                Section.ApiKeyId = value;
            }
        }

        /// <summary>
        /// Gets or sets a shared secret. The shared secret can be retrieved from the
        /// Configuration Center. An <code>apiKeyId</code> and <code>secretApiKey</code> always
        /// go hand-in-hand, the difference is that <code>secretApiKey</code> is never
        /// visible in the HTTP request. This secret is used as input for the HMAC
        /// algorithm.
        /// </summary>
        public string SecretApiKey
        {
            get
            {
                return Section.SecretApiKey;
            }
            set
            {
                Section.SecretApiKey = value;
            }
        }

        internal ProxyConfiguration ProxyConfiguration
        {
            get
            {
                return Section.ProxyConfiguration;
            }
        }

        /// <summary>
        /// Gets the proxy object
        /// </summary>
        public Proxy Proxy => new Proxy { Username = ProxyConfiguration.Username, Password = ProxyConfiguration.Password, Uri = ProxyConfiguration.Uri };

        /// <summary>
        /// Gets or sets the proxy URI.
        /// </summary>
        public Uri ProxyUri
        {
            get
            {
                return Section.ProxyUri;
            }
            set
            {
                Section.ProxyUri = value;
            }
        }

        /// <summary>
        /// Gets or sets the proxy username.
        /// </summary>
        public string ProxyUserName
        {
            get
            {
                return Section.ProxyUserName;
            }
            set
            {
                Section.ProxyUserName = value;
            }
        }

        /// <summary>
        /// Gets or sets the proxy password.
        /// </summary>
        public string ProxyPassword
        {
            get
            {
                return Section.ProxyPassword;
            }
            set
            {
                Section.ProxyPassword = value;
            }
        }

        /// <summary>
        /// Gets or sets the integrator.
        /// </summary>
        public string Integrator
        {
            get
            {
                return Section.Integrator;
            }

            set
            {
                Section.Integrator = value;
            }
        }

        /// <summary>
        /// Gets or sets the shoppingcart extension.
        /// </summary>
        public ShoppingCartExtension ShoppingCartExtension
        {
            get
            {
                return Section.ShoppingCartExtension;
            }

            set
            {
                Section.ShoppingCartExtension = value;
            }
        }

        public CommunicatorConfiguration()
        {

        }

        public CommunicatorConfiguration(IDictionary<string, string> properties)
        {
            if (properties != null)
            {
                ApiEndpoint = GetApiEndpoint(properties);
                AuthorizationType = AuthorizationType.GetValueOf(GetProperty(properties, "connect.api.authorizationType"));
                
                var connectTimout = int.Parse(GetProperty(properties, "connect.api.connectTimeout"));
                ConnectTimeout = (connectTimout < 0) ? (TimeSpan?)TimeSpan.FromMilliseconds(connectTimout) : null;

                var socketTimout = int.Parse(GetProperty(properties, "connect.api.socketTimeout"));
                SocketTimeout = (socketTimout < 0) ? (TimeSpan?)TimeSpan.FromMilliseconds(socketTimout) : null;
                
                MaxConnections = GetProperty(properties, "connect.api.maxConnections", DefaultMaxConnections);

                var proxyURI = GetProperty(properties, "connect.api.proxy.uri");
                var proxyUser = GetProperty(properties, "connect.api.proxy.username");
                var proxyPass = GetProperty(properties, "connect.api.proxy.password");
                if (proxyURI != null)
                {
                    ProxyConfiguration.Uri = new Uri(proxyURI);
                    ProxyConfiguration.Username = proxyUser;
                    ProxyConfiguration.Password = proxyPass;
                }

                Integrator = GetProperty(properties, "connect.api.integrator", "");
            }
        }

        /// <summary>
        /// Returns this with the API endpoint assigned.
        /// </summary>
        /// <param name="apiEndpoint">API endpoint.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithApiEndpoint(Uri apiEndpoint)
        {
            ApiEndpoint = apiEndpoint;
            return this;
        }

        /// <summary>
        /// Returns this with the API key identifier assigned.
        /// </summary>
        /// <param name="apiKeyId">The API key id</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithApiKeyId(string apiKeyId)
        {
            ApiKeyId = apiKeyId;
            return this;
        }

        /// <summary>
        /// Returns this with the secret API key assigned.
        /// </summary>
        /// <param name="secretApiKey">Secret API key.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithSecretApiKey(string secretApiKey)
        {
            SecretApiKey = secretApiKey;
            return this;
        }

        /// <summary>
        /// Returns this with the type of the authorization assigned.
        /// </summary>
        /// <param name="authorizationType">Authorization type.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithAuthorizationType(AuthorizationType authorizationType)
        {
            AuthorizationType = authorizationType;
            return this;
        }

        /// <summary>
        /// Returns this with the the connect timeout assigned.
        /// </summary>
        /// <param name="connectTimeout">The connect timeout.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithConnectTimeout(int connectTimeout)
        {
            ConnectTimeout = TimeSpan.FromMilliseconds(connectTimeout);
            return this;
        }

        /// <summary>
        /// Returns this with the the socket timeout assigned.
        /// </summary>
        /// <param name="socketTimeout">The socket timeout.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithSocketTimeout(int socketTimeout)
        {
            SocketTimeout = TimeSpan.FromMilliseconds(socketTimeout);
            return this;
        }

        /// <summary>
        /// Returns this with the maximum number of connections assigned.
        /// </summary>
        /// <param name="maxConnections">The maximum number of connections.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithMaxConnections(int maxConnections)
        {
            MaxConnections = maxConnections;
            return this;
        }

        /// <summary>
        /// Returns this with the proxy URI assigned.
        /// </summary>
        /// <param name="proxyUri">The proxy URI.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithProxyUri(Uri proxyUri)
        {
            ProxyConfiguration.Uri = proxyUri;
            return this;
        }

        /// <summary>
        /// Returns this with the proxy username assigned.
        /// </summary>
        /// <param name="proxyName">The proxy username.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithProxyUserName(string proxyName)
        {
            ProxyConfiguration.Username = proxyName;
            return this;
        }

        /// <summary>
        /// Returns this with the proxy password assigned.
        /// </summary>
        /// <param name="proxyPassword">The proxy password.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithProxyPassword(string proxyPassword)
        {
            ProxyConfiguration.Password = proxyPassword;
            return this;
        }

        /// <summary>
        /// Returns this with the integrator assigned.
        /// </summary>
        /// <param name="integrator">The integrator.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithIntegrator(string integrator)
        {
            Integrator = integrator;
            return this;
        }

        /// <summary>
        /// Returns this with the shopping cart extension assigned.
        /// </summary>
        /// <param name="shoppingCartExtension">The shopping cart extension.</param>
        /// <returns>This.</returns>
        public CommunicatorConfiguration WithShoppingCartExtension(ShoppingCartExtension shoppingCartExtension)
        {
            ShoppingCartExtension = shoppingCartExtension;
            return this;
        }

        internal CommunicatorConfiguration(CommunicatorConfigurationSection section)
        {
            Section = section;
        }

        static string GetProperty(IDictionary<string, string> properties, string name, string defaultValue = null)
        {
            if (properties.ContainsKey(name))
            {
                return properties[name];
            }
            return defaultValue;
        }

        static int GetProperty(IDictionary<string, string> properties, string key, int defaultValue)
        {
            string propertyValue = GetProperty(properties, key);
            if (int.TryParse(propertyValue, out int propertyInt))
            {
                return propertyInt;
            }
            return defaultValue;
        }

        Uri GetApiEndpoint(IDictionary<string, string> properties)
        {
            var host = GetProperty(properties, "connect.api.endpoint.host", "");
            var scheme = GetProperty(properties, "connect.api.endpoint.scheme", "https");
            var port = GetProperty(properties, "connect.api.endpoint.port", -1);

            return CreateURI(scheme, host, port);

        }

        Uri CreateURI(string scheme, string host, int port)
        {
            try
            {
                return new UriBuilder(scheme: scheme, host: host, portNumber: port).Uri;
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentException("Unable to construct API endpoint URI", e);
            }
        }
    }
}
