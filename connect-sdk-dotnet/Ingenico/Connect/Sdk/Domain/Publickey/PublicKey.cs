/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Newtonsoft.Json;

namespace Ingenico.Connect.Sdk.Domain.Publickey
{
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
