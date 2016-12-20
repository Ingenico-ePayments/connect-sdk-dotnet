/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Newtonsoft.Json;

namespace Ingenico.Connect.Sdk.Domain.Publickey
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PublicKey">PublicKey</a>
    /// </summary>
    public class PublicKey
    {
        public string KeyId { get; set; } = null;

        /// <summary>
        /// Property publicKey
        /// </summary>
        [JsonProperty(PropertyName = "publicKey")]
        public string EncodedPublicKey { get; set; } = null;
    }
}
