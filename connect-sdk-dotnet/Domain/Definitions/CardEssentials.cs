/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class CardEssentials
    {
        /// <summary>
        /// The complete credit/debit card number
        /// </summary>
        public string CardNumber { get; set; } = null;

        /// <summary>
        /// The card holder's name on the card.
        /// </summary>
        public string CardholderName { get; set; } = null;

        /// <summary>
        /// Expiry date of the card
        /// <br />Format: MMYY
        /// </summary>
        public string ExpiryDate { get; set; } = null;
    }
}
