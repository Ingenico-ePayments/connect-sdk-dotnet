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
        /// <summary>
        /// Object that holds airline specific data
        /// </summary>
        public AirlineData AirlineData { get; set; } = null;

        /// <summary>
        /// Object containing data related to installments which can be used for card payments and only with some acquirers. In case you send in the details of this object, only the combination of card products and acquirers that do support installments will be shown on the MyCheckout hosted payment pages.
        /// </summary>
        public Installments Installments { get; set; } = null;

        /// <summary>
        /// Object that holds Level3 summary data
        /// </summary>
        [ObsoleteAttribute("Use Order.shoppingCart.amountBreakdown instead")]
        public Level3SummaryData Level3SummaryData { get; set; } = null;

        /// <summary>
        /// Object containing specific data regarding the recipient of a loan in the UK
        /// </summary>
        public LoanRecipient LoanRecipient { get; set; } = null;

        /// <summary>
        /// Object that holds lodging specific data
        /// </summary>
        public LodgingData LodgingData { get; set; } = null;

        /// <summary>
        /// The number of installments in which this transaction will be paid, which can be used for card payments. Only used with some acquirers. In case you send in the details of this object, only the combination of card products and acquirers that do support installments will be shown on the MyCheckout hosted payment pages.
        /// </summary>
        [ObsoleteAttribute("Use installments.numberOfInstallments instead")]
        public long? NumberOfInstallments { get; set; } = null;

        /// <summary>
        /// Date and time of order
        /// <br />Format: YYYYMMDDHH24MISS
        /// </summary>
        public string OrderDate { get; set; } = null;

        /// <summary>
        /// Object that holds the purchase and usage type indicators
        /// </summary>
        public OrderTypeInformation TypeInformation { get; set; } = null;
    }
}
