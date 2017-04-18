/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_Level3SummaryData">Level3SummaryData</a>
    /// </summary>
    [ObsoleteAttribute("Use ShoppingCart instead")]
    public class Level3SummaryData
    {
        [ObsoleteAttribute("Use ShoppingCart.discountAmount instead")]
        public long? DiscountAmount { get; set; } = null;

        [ObsoleteAttribute("Use ShoppingCart.dutyAmount instead")]
        public long? DutyAmount { get; set; } = null;

        [ObsoleteAttribute("Use ShoppingCart.shippingAmount instead")]
        public long? ShippingAmount { get; set; } = null;
    }
}
