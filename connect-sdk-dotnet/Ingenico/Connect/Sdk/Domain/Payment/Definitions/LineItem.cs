/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class LineItem
    {
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public LineItemInvoiceData InvoiceData { get; set; } = null;

        [ObsoleteAttribute("Use orderLineDetails instead")]
        public LineItemLevel3InterchangeInformation Level3InterchangeInformation { get; set; } = null;

        public OrderLineDetails OrderLineDetails { get; set; } = null;
    }
}
