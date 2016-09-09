using System;
using NLog;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// A communicator logger that is backed by an <see cref="ILogger"/>.
    /// </summary>
    public class NLogCommunicatorLogger : ICommunicatorLogger
    {
        /// <summary>
        /// Creates a new communicator logger.
        /// </summary>
        /// <param name="logger">The backing logger.</param>
        /// <param name="level">The level to use when logging through both <see cref="Log(string)"/> abd <see cref="Log(string, Exception)"/>.</param>
        public NLogCommunicatorLogger(ILogger logger, LogLevel level) : this(logger, level, level)
        {

        }

        /// <summary>
        /// Creates a new communicator logger.
        /// </summary>
        /// <param name="logger">The backing logger.</param>
        /// <param name="logLevel">The level to use when logging through <see cref="Log(string)"/></param>
        /// <param name="errorLogLevel">The level to use when logging through <see cref="Log(string, Exception)"/></param>
        public NLogCommunicatorLogger(ILogger logger, LogLevel logLevel, LogLevel errorLogLevel)
        {
            if (logger == null)
            {
                throw new ArgumentNullException();
            }
            if (logLevel == null)
            {
                logLevel = LogLevel.Debug;
            }
            if (errorLogLevel == null)
            {
                logLevel = LogLevel.Error;
            }

            _logger = logger;
            _logLevel = logLevel;
            _errorLogLevel = errorLogLevel;
        }

        #region ICommunicatorLogger Implementation
        public void Log(string message)
        {
            _logger.Log(_logLevel, message);
        }

        public void Log(string message, Exception exception)
        {
            _logger.Log(_errorLogLevel, message, exception, new object[0]);
        }
        #endregion

        readonly ILogger _logger;
        readonly LogLevel _logLevel;
        readonly LogLevel _errorLogLevel;
    }
}
