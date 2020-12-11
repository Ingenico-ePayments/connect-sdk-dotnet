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
        /// <summary>
        /// Discount on the entire transaction, with the last 2 digits are implied decimal places
        /// </summary>
        [ObsoleteAttribute("Use ShoppingCart.amountBreakdown with type DISCOUNT instead")]
        public long? DiscountAmount { get; set; } = null;

        /// <summary>
        /// Duty on the entire transaction, with the last 2 digits are implied decimal places
        /// </summary>
        [ObsoleteAttribute("Use ShoppingCart.amountBreakdown with type DUTY instead")]
        public long? DutyAmount { get; set; } = null;

        /// <summary>
        /// Shippingcost on the entire transaction, with the last 2 digits are implied decimal places
        /// </summary>
        [ObsoleteAttribute("Use ShoppingCart.amountBreakdown with type SHIPPING instead")]
        public long? ShippingAmount { get; set; } = null;
    }
}
