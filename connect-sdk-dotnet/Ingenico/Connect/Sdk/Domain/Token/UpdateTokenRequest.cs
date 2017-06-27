/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Token.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token
{
    public class UpdateTokenRequest
    {
        public TokenCard Card { get; set; } = null;

        public TokenEWallet EWallet { get; set; } = null;

        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;

        public TokenSepaDirectDebitWithoutCreditor SepaDirectDebit { get; set; } = null;
    }
}
