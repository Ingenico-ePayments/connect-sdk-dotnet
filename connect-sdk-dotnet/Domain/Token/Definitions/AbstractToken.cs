/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class AbstractToken
    {
        /// <summary>
        /// An alias for the token. This can be used to visually represent the token.
        /// <br />If no alias is given in Create token calls, a payment product specific default is used, e.g. the obfuscated card number for card payment products.
        /// <br />Do not include any unobfuscated sensitive data in the alias.
        /// </summary>
        public string Alias { get; set; } = null;
    }
}
