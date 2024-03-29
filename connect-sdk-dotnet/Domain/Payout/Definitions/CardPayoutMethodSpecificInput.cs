/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    public class CardPayoutMethodSpecificInput : AbstractPayoutMethodSpecificInput
    {
        /// <summary>
        /// Object containing the card details.
        /// </summary>
        public Card Card { get; set; } = null;

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; } = null;

        /// <summary>
        /// Object containing the details of the recipient of the payout
        /// </summary>
        public PayoutRecipient Recipient { get; set; } = null;

        /// <summary>
        /// ID of the token that holds previously stored card data.
        /// <br /> If both the token and card are provided, then the card takes precedence over the token.
        /// </summary>
        public string Token { get; set; } = null;
    }
}
