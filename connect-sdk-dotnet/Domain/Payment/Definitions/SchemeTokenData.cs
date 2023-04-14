/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class SchemeTokenData
    {
        /// <summary>
        /// The Token Cryptogram is a dynamic one-time use value that is used to verify the authenticity of the transaction and the integrity of the data used in the generation of the Token Cryptogram. Visa calls this the Token Authentication Verification Value (TAVV) cryptogram.
        /// </summary>
        public string Cryptogram { get; set; } = null;

        /// <summary>
        /// The Electronic Commerce Indicator you got with the Token Cryptogram
        /// </summary>
        public string Eci { get; set; } = null;

        /// <summary>
        /// The network token. Note: This is called Payment Token in the EMVCo documentation
        /// </summary>
        public string NetworkToken { get; set; } = null;

        /// <summary>
        /// The expiry date of the network token
        /// </summary>
        public string TokenExpiryDate { get; set; } = null;
    }
}
