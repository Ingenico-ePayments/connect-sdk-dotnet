using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents a pooled connection to the Ingenico ePayments platform server.
    /// Instead of setting up a new HTTP connection for each request, this 
    /// connection uses a pool of HTTP connections. 
    /// Thread-safe.
    /// </summary>
    public interface IPooledConnection : IConnection
    {
        /// <summary>
        /// Closes all HTTP connections that have been idle for the specified time. This should also include all expired HTTP connections. <see cref="CloseExpiredConnections"/>
        /// </summary>
        /// <param name="timespan">Idle time.</param>
        void CloseIdleConnections(TimeSpan timespan);

        /// <summary>
        /// Closes all expired HTTP connections.
        /// </summary>
        void CloseExpiredConnections();
    }
}
