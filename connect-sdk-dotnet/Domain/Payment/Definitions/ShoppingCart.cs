/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ShoppingCart
    {
        public IList<AmountBreakdown> AmountBreakdown { get; set; } = null;

        public GiftCardPurchase GiftCardPurchase { get; set; } = null;

        public bool? IsPreOrder { get; set; } = null;

        public IList<LineItem> Items { get; set; } = null;

        public string PreOrderItemAvailabilityDate { get; set; } = null;

        public bool? ReOrderIndicator { get; set; } = null;
    }
}
