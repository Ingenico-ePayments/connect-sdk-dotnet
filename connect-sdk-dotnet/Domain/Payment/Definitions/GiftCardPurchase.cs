/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class GiftCardPurchase
    {
        /// <summary>
        /// Object containing information on an amount of money
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// Number of gift cards that are purchased through this transaction
        /// </summary>
        public int? NumberOfGiftCards { get; set; } = null;
    }
}
