/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class LineItem
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// <br />Note: make sure you submit the amount and currency code for each line item
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// Object containing the line items of the invoice or shopping cart. The '+' character is not allowed in this property for transactions that are processed by TechProcess Payment Platform.
        /// </summary>
        public LineItemInvoiceData InvoiceData { get; set; } = null;

        /// <summary>
        /// Object containing additional information that when supplied can have a beneficial effect on the discountrates
        /// </summary>
        [Obsolete("Use orderLineDetails instead")]
        public LineItemLevel3InterchangeInformation Level3InterchangeInformation { get; set; } = null;

        /// <summary>
        /// Object containing additional information that when supplied can have a beneficial effect on the discountrates
        /// </summary>
        public OrderLineDetails OrderLineDetails { get; set; } = null;
    }
}
