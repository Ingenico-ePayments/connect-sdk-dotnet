/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    [ObsoleteAttribute("Use Order.shoppingCart instead")]
    public class Level3SummaryData
    {
        [ObsoleteAttribute("Use ShoppingCart.amountbreakdown with type DISCOUNT instead")]
        public long? DiscountAmount { get; set; } = null;

        [ObsoleteAttribute("Use ShoppingCart.amountbreakdown with type DUTY instead")]
        public long? DutyAmount { get; set; } = null;

        [ObsoleteAttribute("Use ShoppingCart.amountbreakdown with type SHIPPING instead")]
        public long? ShippingAmount { get; set; } = null;
    }
}
