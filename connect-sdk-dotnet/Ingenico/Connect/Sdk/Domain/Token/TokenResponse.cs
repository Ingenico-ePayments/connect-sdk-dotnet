/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Token.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_TokenResponse">TokenResponse</a>
    /// </summary>
    public class TokenResponse
    {
        public TokenCard Card { get; set; } = null;

        public TokenEWallet EWallet { get; set; } = null;

        public string Id { get; set; } = null;

        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;

        public TokenSepaDirectDebit SepaDirectDebit { get; set; } = null;
    }
}
