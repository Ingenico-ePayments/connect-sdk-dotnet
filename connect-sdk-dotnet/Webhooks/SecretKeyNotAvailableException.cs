using System;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// Represents an error that causes a secret key to not be available.
    /// </summary>
    public class SecretKeyNotAvailableException : SignatureValidationException
    {
        public string KeyId { get; }

        public SecretKeyNotAvailableException (string message, string keyId = null, Exception innerException = null) : base(message, innerException)
        {
            KeyId = keyId;
        }
    }
}
