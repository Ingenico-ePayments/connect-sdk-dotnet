using System;
using System.Configuration;

namespace Ingenico.Connect.Sdk
{
    class CommunicatorConfigurationSection : ConfigurationSection
    {
        /// <summary>
        /// The default number of maximum connections
        /// </summary>
        public const int DEFAULT_MAX_CONNECTIONS = 10;

        [ConfigurationProperty("apiEndpoint", IsRequired = true)]
        public UriConfiguration ApiEndpointConfig
        {
            get
            {
                var apiEndPoint = this["apiEndpoint"];
                return (UriConfiguration)apiEndPoint;
            }
        }

        public Uri ApiEndpoint
        {
            get
            {
                return ApiEndpointConfig.Uri;
            }
            set
            {
                ApiEndpointConfig.Uri = value;
            }
        }

        [ConfigurationProperty("connectTimeout", IsRequired = true)]
        public int? ConnectTimeoutProperty
        {
            get
            {
                return _connectTimeout ?? (int)this["connectTimeout"];
            }
            set
            {
                if (IsReadOnly())
                {
                    _connectTimeout = value;
                    return;
                }
                this["connectTimeout"] = value;
            }

        }
        int? _connectTimeout;

        public TimeSpan? ConnectTimeout
        {
            get
            {
                return TimeSpan.FromMilliseconds(ConnectTimeoutProperty ?? -1);
            }
            set
            {
                ConnectTimeoutProperty = (int)(value?.TotalMilliseconds ?? -1);
            }
        }

        [ConfigurationProperty("socketTimeout", IsRequired = true)]
        public int? SocketTimeoutProperty
        {
            get
            {
                return _socketTimeout ?? (int)this["socketTimeout"];
            }
            set
            {
                if (IsReadOnly())
                {
                    _socketTimeout = value;
                    return;
                }
                this["socketTimeout"] = value;
            }

        }
        int? _socketTimeout;

        public TimeSpan? SocketTimeout
        {
            get
            {
                return TimeSpan.FromMilliseconds(SocketTimeoutProperty ?? -1);
            }
            set
            {
                SocketTimeoutProperty = (int)(value?.TotalMilliseconds ?? -1);
            }
        }

        [ConfigurationProperty("maxConnections", IsRequired = false, DefaultValue = DEFAULT_MAX_CONNECTIONS)]
        public int MaxConnections
        {
            get
            {
                if (_maxConnections == 0)
                {
                    return (int)this["maxConnections"];

                }
                return _maxConnections;
            }
            set
            {
                if (IsReadOnly())
                {
                    _maxConnections = value;
                    return;
                }
                this["maxConnections"] = value;
            }
        }
        int _maxConnections;

        /// <summary>
        /// Gets or sets the type of the authorization.
        /// </summary>
        /// <value>The type of the authorization.</value>
        [ConfigurationProperty("authorizationType", IsRequired = true)]
        public string AuthorizationType
        {
            get
            {
                return _authorizationType ?? ((string)this["authorizationType"]);
            }
            set
            {
                if (IsReadOnly())
                {
                    _authorizationType = value;
                    return;
                }
                this["authorizationType"] = value;
            }
        }
        string _authorizationType;

        [ConfigurationProperty("apiKeyId", IsRequired = false)]
        public string ApiKeyId
        {
            get
            {
                return _apiKeyId ?? ((string)this["apiKeyId"]).NullIfEmpty();
            }
            set
            {
                if (IsReadOnly())
                {
                    _apiKeyId = value;
                    return;
                }
                this["apiKeyId"] = value;
            }
        }
        string _apiKeyId;

        [ConfigurationProperty("integrator", IsRequired = false)]
        public string Integrator
        {
            get
            {
                return _integrator ?? ((string)this["integrator"]).NullIfEmpty();
            }
            set
            {
                if (IsReadOnly())
                {
                    _integrator = value;
                    return;
                }
                this["integrator"] = value;
            }
        }
        string _integrator;

        public ShoppingCartExtension ShoppingCartExtension
        {
            get
            {
                return ShoppingCartExtensionConfiguration.ShoppingCartExtension;
            }
            set
            {
                ShoppingCartExtensionConfiguration.ShoppingCartExtension = value;
            }
        }

        [ConfigurationProperty("shoppingCartExtension", IsRequired = false)]
        public ShoppingCartExtensionConfiguration ShoppingCartExtensionConfiguration
        {
            get
            {
                return (ShoppingCartExtensionConfiguration)this["shoppingCartExtension"];
            }
        }

        /// <summary>
        /// A shared secret. The shared secret can be retrieved from the
        /// Configuration Center. An {@code apiKeyId} and {@code secretApiKey} always
        /// go hand-in-hand, the difference is that {@code secretApiKey} is never
        /// visible in the HTTP request. This secret is used as input for the HMAC
        /// algorithm.
        /// </summary>
        /// <value>The secret API key.</value>
        [ConfigurationProperty("secretApiKey", IsRequired = false)]
        public string SecretApiKey
        {
            get
            {
                return _secretApiKey ?? ((string)this["secretApiKey"]).NullIfEmpty();
            }
            set
            {
                if (IsReadOnly())
                {
                    _secretApiKey = value;
                    return;
                }
                this["secretApiKey"] = value;
            }
        }
        string _secretApiKey;

        [ConfigurationProperty("proxy", IsRequired = false)]
        public ProxyConfiguration ProxyConfiguration
        {
            get
            {
                return this["proxy"] as ProxyConfiguration;
            }
        }

        public Uri ProxyUri
        {
            get
            {
                return ProxyConfiguration.Uri;
            }
            set
            {
                ProxyConfiguration.Uri = value;
            }
        }

        public string ProxyUserName
        {
            get
            {
                return ProxyConfiguration.Username;
            }
            set
            {
                ProxyConfiguration.Username = value;
            }
        }

        public string ProxyPassword
        {
            get
            {
                return ProxyConfiguration.Password;
            }
            set
            {
                ProxyConfiguration.Password = value;
            }
        }
    }
}
