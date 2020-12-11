/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Token.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token
{
    public class TokenResponse
    {
        /// <summary>
        /// Object containing card details
        /// </summary>
        public TokenCard Card { get; set; } = null;

        /// <summary>
        /// Object containing eWallet details
        /// </summary>
        public TokenEWallet EWallet { get; set; } = null;

        /// <summary>
        /// ID of the token
        /// </summary>
        public string Id { get; set; } = null;

        /// <summary>
        /// Object containing the non SEPA Direct Debit details
        /// </summary>
        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; } = null;

        /// <summary>
        /// The initial Payment ID of the transaction from which the token has been created
        /// </summary>
        public string OriginalPaymentId { get; set; } = null;

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; } = null;

        /// <summary>
        /// Object containing the SEPA Direct Debit details
        /// </summary>
        public TokenSepaDirectDebit SepaDirectDebit { get; set; } = null;
    }
}
