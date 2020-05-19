using System;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// A store of secret keys. Implementations could store secret keys in a database, on disk, etc.
    /// Thread-safe.
    /// </summary>
    public interface ISecretKeyStore
    {
        /// <summary>
        /// Gets the secret key for the given key id. Never <c>null</c>.
        /// </summary>
        /// <exception cref="SecretKeyNotAvailableException">If the secret key for the given key id is not available.</exception>
        string GetSecretKey(string keyId);
    }
}
