/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    [ObsoleteAttribute("Use ShoppingCart.amountBreakdown instead")]
    public class Level3SummaryData
    {
        [ObsoleteAttribute("Use ShoppingCart.amountBreakdown with type DISCOUNT instead")]
        public long? DiscountAmount { get; set; } = null;

        [ObsoleteAttribute("Use ShoppingCart.amountBreakdown with type DUTY instead")]
        public long? DutyAmount { get; set; } = null;

        [ObsoleteAttribute("Use ShoppingCart.amountBreakdown with type SHIPPING instead")]
        public long? ShippingAmount { get; set; } = null;
    }
}
