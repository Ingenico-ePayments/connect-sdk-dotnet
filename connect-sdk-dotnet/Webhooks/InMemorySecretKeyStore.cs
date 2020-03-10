using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// An in-memory secret key store.
    /// This implementation can be used in applications where secret keys can be specified at application startup.
    /// Thread-safe.
    /// </summary>
    public class InMemorySecretKeyStore : ISecretKeyStore
    {
        private InMemorySecretKeyStore ()
        {
        }

        public static readonly InMemorySecretKeyStore Instance = new InMemorySecretKeyStore ();

        private readonly IDictionary<string,string> store = new ConcurrentDictionary<string, string> ();

        /// <summary>
        /// Stores the given secret key for the given key id.
        /// </summary>
        public void StoreSecretKey(string keyId, string secretKey) {
            if (keyId == null || keyId.Trim().IsEmpty()) {
                throw new ArgumentNullException ("keyId is required");
            }
            if (secretKey == null || secretKey.Trim().IsEmpty()) {
                throw new ArgumentNullException("secretKey is required");
            }
            store.Add(keyId, secretKey);
        }

        /// <summary>
        /// Removes the secret key for the given key id.
        /// </summary>
        public void RemoveSecretKey(string keyId) {
            store.Remove (keyId);
        }

        /// <summary>
        /// Removes all stored secret keys
        /// </summary>
        public void Clear() {
            store.Clear ();
        }

        public string GetSecretKey(string keyId)
        {
            if (store.TryGetValue(keyId, out string secretKey))
            {
                return secretKey;
            }
            throw new SecretKeyNotAvailableException("Could not find secret key for key id" + keyId, keyId);
        }
    }
}
