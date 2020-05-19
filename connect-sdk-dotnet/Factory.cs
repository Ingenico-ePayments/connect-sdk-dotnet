using System;
using System.Collections.Generic;
using Ingenico.Connect.Sdk.DefaultImpl;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Ingenico ePayments platform factory for several SDK components.
    /// </summary>
    public sealed class Factory
    {
        /// <summary>
        /// Creates a <see cref="CommunicatorConfiguration"/> based on the configuration values in
        /// your <c>app.conf</c> or <c>web.conf</c> file, <c>apiKeyId</c> and <c>secretApiKey</c>.
        /// </summary>
        /// <param name="apiKeyId">The API key identifier.</param>
        /// <param name="secretApiKey">The secret API key.</param>
        /// <returns>The communicator configuration that can still be changed.</returns>
        public static CommunicatorConfiguration CreateConfiguration(string apiKeyId, string secretApiKey)
        {
            var configurationSection = System.Configuration.ConfigurationManager.GetSection("ConnectSDK") as CommunicatorConfigurationSection;
            if (configurationSection == null)
            {
                throw new InvalidOperationException("Unable to load configuration");
            }
            var configuration = new CommunicatorConfiguration(configurationSection);
            if (apiKeyId != null)
            {
                configuration.ApiKeyId = apiKeyId;
            }
            if (secretApiKey != null)
            {
                configuration.SecretApiKey = secretApiKey;
            }
            return configuration;
        }

        /// <summary>
        /// Creates a <see cref="CommunicatorConfiguration"/> based on the configuration
        /// values in <c>configurationDictionary</c>, <c>apiKeyId</c> and <c>secretApiKey</c>.
        /// </summary>
        /// <param name="configurationDictionary">Dictionary containing configuration.</param>
        /// <param name="apiKeyId">The API key identifier.</param>
        /// <param name="secretApiKey">The secret API key.</param>
        /// <returns>The communicator configuration that can still be changed.</returns>
        public static CommunicatorConfiguration CreateConfiguration(IDictionary<string, string> configurationDictionary, string apiKeyId, string secretApiKey)
        {
            var configuration = new CommunicatorConfiguration(configurationDictionary);
            if (apiKeyId != null)
            {
                configuration.ApiKeyId = apiKeyId;
            }
            if (secretApiKey != null)
            {
                configuration.SecretApiKey = secretApiKey;
            }
            return configuration;
        }

        /// <summary>
        /// Creates a <see cref="SessionBuilder"/> based on the configuration values in
        /// your <c>app.conf</c> or <c>web.conf</c> file, <c>apiKeyId</c> and <c>secretApiKey</c>.
        /// </summary>
        /// <param name="apiKeyId">The API key identifier.</param>
        /// <param name="secretApiKey">The secret API key.</param>
        public static SessionBuilder CreateSessionBuilder(string apiKeyId, string secretApiKey)
        {
            CommunicatorConfiguration configuration = CreateConfiguration(apiKeyId, secretApiKey);
            return CreateSessionBuilder(configuration);
        }

        /// <summary>
        /// Creates a <see cref="SessionBuilder"/> based on the configuration
        /// values in <c>configurationDictionary</c>, <c>apiKeyId</c> and <c>secretApiKey</c>.
        /// </summary>
        /// <param name="configurationDictionary">Dictionary containing configuration.</param>
        /// <param name="apiKeyId">The API key identifier.</param>
        /// <param name="secretApiKey">The secret API key.</param>
        public static SessionBuilder CreateSessionBuilder(IDictionary<string, string> configurationDictionary, string apiKeyId, string secretApiKey)
        {
            return CreateSessionBuilder(CreateConfiguration(configurationDictionary, apiKeyId, secretApiKey));
        }

        /// <summary>
        /// Creates a <see cref="SessionBuilder"/> based on the passed configuration.
        /// </summary>
        public static SessionBuilder CreateSessionBuilder(CommunicatorConfiguration configuration)
        {
            return new SessionBuilder()
                    .WithApiEndpoint(configuration.ApiEndpoint)
                    .WithConnection(new DefaultConnection(
                            configuration.SocketTimeout,
                            // connect timeout not supported
                            configuration.ProxyConfiguration,
                            configuration.MaxConnections
                    ))
                    .WithMetaDataProvider(
                        new MetaDataProviderBuilder(configuration.Integrator)
                        {
                            ShoppingCartExtension = configuration.ShoppingCartExtension
                        }.Build()
                    )
                    .WithAuthenticator(new DefaultAuthenticator(
                    configuration.AuthorizationType,
                            configuration.ApiKeyId,
                            configuration.SecretApiKey
                    ));
        }

        /// <summary>
        /// Creates a <see cref="Communicator"/> based on the configuration values in
        /// your <c>app.conf</c> or <c>web.conf</c> file, <c>apiKeyId</c> and <c>secretApiKey</c>.
        /// </summary>
        /// <param name="apiKeyId">The API key identifier.</param>
        /// <param name="secretApiKey">The secret API key.</param>
        public static Communicator CreateCommunicator(string apiKeyId, string secretApiKey)
        {
            CommunicatorConfiguration configuration = CreateConfiguration(apiKeyId, secretApiKey);
            return CreateCommunicator(configuration);

        }

        /// <summary>
        /// Creates a <see cref="Communicator"/> based on the configuration values
        /// <c>configurationDictionary</c>, <c>apiKeyId</c> and <c>secretApiKey</c>.
        /// </summary>
        /// <param name="configurationDictionary">Dictionary containing configuration.</param>
        /// <param name="apiKeyId">The API key identifier.</param>
        /// <param name="secretApiKey">The secret API key.</param>
        public static Communicator CreateCommunicator(IDictionary<string, string> configurationDictionary, string apiKeyId, string secretApiKey)
        {
            CommunicatorConfiguration configuration = CreateConfiguration(configurationDictionary, apiKeyId, secretApiKey);
            return CreateCommunicator(configuration);
        }

        /// <summary>
        /// Creates a <see cref="Communicator"/> based on the passed configuration.
        /// </summary>
        public static Communicator CreateCommunicator(CommunicatorConfiguration configuration)
        {
            SessionBuilder sessionBuilder = CreateSessionBuilder(configuration);
            return CreateCommunicator(sessionBuilder.Build());
        }

        /// <summary>
        /// Creates a <see cref="Communicator"/> based on the passed session.
        /// </summary>
        /// <param name="session">The shared session to use.</param>
        public static Communicator CreateCommunicator(Session session)
        {
            return new Communicator(session, DefaultMarshaller.Instance);
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the configuration values in
        /// your <c>app.conf</c> or <c>web.conf</c> file, <c>apiKeyId</c> and <c>secretApiKey</c>.
        /// </summary>
        /// <param name="apiKeyId">The API key identifier.</param>
        /// <param name="secretApiKey">The secret API key.</param>
        public static Client CreateClient(string apiKeyId, string secretApiKey)
        {
            return CreateClient(CreateCommunicator(apiKeyId, secretApiKey));
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the configuration values in
        /// <c>configurationDictionary</c>, <c>apiKeyId</c> and <c>secretApiKey</c>.
        /// </summary>
        /// <param name="configurationDictionary">Dictionary containing configuration.</param>
        /// <param name="apiKeyId">The API key identifier.</param>
        /// <param name="secretApiKey">The secret API key.</param>
        public static Client CreateClient(IDictionary<string, string> configurationDictionary, string apiKeyId, string secretApiKey)
        {
            return CreateClient(CreateCommunicator(configurationDictionary, apiKeyId, secretApiKey));
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the passed configuration.
        /// </summary>
        public static Client CreateClient(CommunicatorConfiguration configuration)
        {
            return CreateClient(CreateCommunicator(configuration));
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the passed session.
        /// </summary>
        /// <param name="session">The shared session to use.</param>
        public static Client CreateClient(Session session)
        {
            return CreateClient(CreateCommunicator(session));
        }

        /// <summary>
        /// Creates a <see cref="Client"/> based on the passed communicator.
        /// </summary>
        /// <param name="communicator">The shared communicator to use.</param>
        public static Client CreateClient(Communicator communicator)
        {
            return new Client(communicator);
        }

        Factory() { }
    }
}
