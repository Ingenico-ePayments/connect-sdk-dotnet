/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class AdditionalOrderInput
    {
        public AirlineData AirlineData { get; set; } = null;

        [ObsoleteAttribute("Use Order.shoppingCart.amountBreakdown instead")]
        public Level3SummaryData Level3SummaryData { get; set; } = null;

        public LoanRecipient LoanRecipient { get; set; } = null;

        public long? NumberOfInstallments { get; set; } = null;

        public string OrderDate { get; set; } = null;

        public OrderTypeInformation TypeInformation { get; set; } = null;
    }
}
