/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Token.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token
{
    public class TokenResponse
    {
        public TokenCard Card { get; set; } = null;

        public TokenEWallet EWallet { get; set; } = null;

        public string Id { get; set; } = null;

        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; } = null;

        public string OriginalPaymentId { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;

        public TokenSepaDirectDebit SepaDirectDebit { get; set; } = null;
    }
}
