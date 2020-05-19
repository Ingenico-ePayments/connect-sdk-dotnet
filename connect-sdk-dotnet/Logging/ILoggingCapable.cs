using System;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// Classes that implement this interface have support for logging messages from communicators.
    /// </summary>
    public interface ILoggingCapable
    {
        /// <summary>
        /// Turns on logging using the given communicator logger.
        /// </summary>
        /// <param name="communicatorLogger">The given communicator logger.</param>
        /// <exception cref="ArgumentException">If the given communicator logger is <c>null</c>.</exception>
        void EnableLogging(ICommunicatorLogger communicatorLogger);

        /// <summary>
        /// Turns off logging.
        /// </summary>
        void DisableLogging();
    }
}
