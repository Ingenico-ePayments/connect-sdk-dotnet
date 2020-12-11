/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Token.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token
{
    public class CreateTokenRequest
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
        /// Data that was encrypted client side containing all customer entered data elements like card data.
        /// <br />Note: Because this data can only be submitted once to our system and contains encrypted card data you should not store it. As the data was captured within the context of a client session you also need to submit it to us before the session has expired.
        /// </summary>
        public string EncryptedCustomerInput { get; set; } = null;

        /// <summary>
        /// Object containing non SEPA Direct Debit details
        /// </summary>
        public TokenNonSepaDirectDebit NonSepaDirectDebit { get; set; } = null;

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; } = null;

        /// <summary>
        /// Object containing SEPA Direct Debit details
        /// </summary>
        public TokenSepaDirectDebitWithoutCreditor SepaDirectDebit { get; set; } = null;
    }
}
