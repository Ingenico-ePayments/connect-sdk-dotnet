using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Contains the components needed to communicate with the GlobalCollect platform. Thread-safe.
    /// </summary>
    public class Session
    {
        // Virtual for unit testing
        /// <summary>
        /// Gets the GlobalCollect platform API endpoint URI. This URI's path will be <code>null</code> or empty.
        /// </summary>
        public virtual Uri ApiEndpoint => _apiEndpoint;
        Uri _apiEndpoint;

        /// <summary>
        /// Gets the <see cref="IConnection"/> object associated with this session. Never <code>null</code>.
        /// </summary>
        public IConnection Connection => _connection;
        IConnection _connection;

        /// <summary>
        /// Gets the <see cref="MetaDataProvider"/> object associated with this session. Never <code>null</code>.
        /// </summary>
        public MetaDataProvider MetaDataProvider => _metaDataProvider;
        MetaDataProvider _metaDataProvider;

        /// <summary>
        /// Gets he <see cref="IAuthenticator"/> object associated with this session. Never <code>null</code>.
        /// </summary>
        public IAuthenticator Authenticator => _authenticator;
        IAuthenticator _authenticator;

        public Session(Uri apiEndpoint, IConnection connection, IAuthenticator authenticator,
               MetaDataProvider metaDataProvider)
        {
            if (apiEndpoint == null)
            {
                throw new ArgumentException("apiEndpoint is required");
            }
            if (apiEndpoint.LocalPath != null && apiEndpoint.LocalPath.Length > 0 && !apiEndpoint.LocalPath.Equals("/"))
            {
                throw new ArgumentException("apiEndpoint should not contain a path");
            }
            if (!apiEndpoint.UserInfo.Equals("")
                || !apiEndpoint.Query.Equals("")
                || !apiEndpoint.Fragment.Equals(""))
            {
                throw new ArgumentException("apiEndpoint should not contain user info, query or fragment");
            }
            if (connection == null)
            {
                throw new ArgumentException("connection is required");
            }
            if (authenticator == null)
            {
                throw new ArgumentException("authenticator is required");
            }
            if (metaDataProvider == null)
            {
                throw new ArgumentException("metaDataProvider is required");
            }
            _apiEndpoint = apiEndpoint;
            _connection = connection;
            _authenticator = authenticator;
            _metaDataProvider = metaDataProvider;
        }

        // Only for unit testing, will result in an invalid object
        protected Session()
        {

        }
    }
}
