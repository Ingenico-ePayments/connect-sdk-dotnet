using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Builder for a <see cref="Session"/> object.
    /// </summary>
    public class SessionBuilder
    {
        /// <summary>
        /// Sets the Ingenico ePayments platform API endpoint URI to use.
        /// </summary>
        /// <param name="apiEndpoint">The API endpoint.</param>
        /// <returns>This.</returns>
        public SessionBuilder WithApiEndpoint(Uri apiEndpoint)
        {
            _apiEndpoint = apiEndpoint;
            return this;
        }

        /// <summary>
        /// Sets the <see cref="IConnection"/> to use.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <returns>This.</returns>
        public SessionBuilder WithConnection(IConnection connection)
        {
            _connection = connection;
            return this;
        }

        /// <summary>
        /// Sets the <see cref="IAuthenticator"/> to use.
        /// </summary>
        /// <param name="authenticator">The authenticator.</param>
        /// <returns>This.</returns>
        public SessionBuilder WithAuthenticator(IAuthenticator authenticator)
        {
            _authenticator = authenticator;
            return this;
        }

        /// <summary>
        /// Sets the <see cref="MetaDataProvider"/> to use.
        /// </summary>
        /// <param name="metaDataProvider">Meta data provider.</param>
        /// <returns>This.</returns>
        public SessionBuilder WithMetaDataProvider(MetaDataProvider metaDataProvider)
        {
            _metaDataProvider = metaDataProvider;
            return this;
        }

        /// <summary>
        /// Creates a fully initialized <see cref="Session"/> object.
        /// </summary>
        /// <exception cref="ArgumentException">if not all required components are set</exception>
        public Session Build()
        {
            return new Session(
                _apiEndpoint,
                _connection,
                _authenticator,
                _metaDataProvider
            );
        }

        Uri _apiEndpoint;

        IConnection _connection;

        MetaDataProvider _metaDataProvider;

        IAuthenticator _authenticator;
    }
}
