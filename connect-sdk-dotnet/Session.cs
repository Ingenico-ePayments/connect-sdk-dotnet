using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Contains the components needed to communicate with the Ingenico ePayments platform. Thread-safe.
    /// </summary>
    public class Session
    {
        // Virtual for unit testing
        /// <summary>
        /// Gets the Ingenico ePayments platform API endpoint URI. This URI's path will be <code>null</code> or empty.
        /// </summary>
        public virtual Uri ApiEndpoint { get; }

        /// <summary>
        /// Gets the <see cref="IConnection"/> object associated with this session. Never <code>null</code>.
        /// </summary>
        public IConnection Connection { get; }

        /// <summary>
        /// Gets the <see cref="MetaDataProvider"/> object associated with this session. Never <code>null</code>.
        /// </summary>
        public MetaDataProvider MetaDataProvider { get; }

        /// <summary>
        /// Gets he <see cref="IAuthenticator"/> object associated with this session. Never <code>null</code>.
        /// </summary>
        public IAuthenticator Authenticator { get; }

        public Session(Uri apiEndpoint, IConnection connection, IAuthenticator authenticator,
               MetaDataProvider metaDataProvider)
        {
            if (apiEndpoint == null)
            {
                throw new ArgumentException("apiEndpoint is required");
            }
            if (apiEndpoint.HasPath())
            {
                throw new ArgumentException("apiEndpoint should not contain a path");
            }
            if (apiEndpoint.HasUserInfoOrQueryOrFragment())
            {
                throw new ArgumentException("apiEndpoint should not contain user info, query or fragment");
            }
            ApiEndpoint = apiEndpoint;
            Connection = connection ?? throw new ArgumentException("connection is required");
            Authenticator = authenticator ?? throw new ArgumentException("authenticator is required"); ;
            MetaDataProvider = metaDataProvider ?? throw new ArgumentException("metaDataProvider is required"); ;
        }

        // Only for unit testing, will result in an invalid object
        protected Session()
        {

        }
    }
}
