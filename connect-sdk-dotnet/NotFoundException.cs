using System;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Indicates an exception that occurs when the requested resource is not found.
    /// In normal usage of the SDK, this exception should not occur, however it is possible.
    /// For example when path parameters are set with invalid values.
    /// </summary>
    public class NotFoundException : Exception
    {
        public NotFoundException(string message, Exception exception)
            : base(message, exception)
        {

        }
    }
}
