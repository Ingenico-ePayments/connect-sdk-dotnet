using System;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// Represents an error while validating webhooks signatures.
    /// </summary>
    public class SignatureValidationException : Exception
    {
        public SignatureValidationException (string message, Exception innerException = null) : base(message, innerException)
        {
        }
    }
}
