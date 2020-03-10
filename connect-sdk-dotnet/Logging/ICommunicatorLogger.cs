using System;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// Used to log messages from communicators. Thread-safe.
    /// </summary>
    public interface ICommunicatorLogger
    {
        /// <summary>
        /// Log the specified message.
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Log(string message);

        /// <summary>
        /// Logs a throwable with an accompanying message.
        /// </summary>
        /// <param name="message">Message accompanying the throwable.</param>
        /// <param name="thrown">The throwable to log.</param>
        void Log(string message, Exception thrown);
    }
}
