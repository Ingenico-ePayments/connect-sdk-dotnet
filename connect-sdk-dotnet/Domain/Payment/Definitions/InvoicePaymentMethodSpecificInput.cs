/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class InvoicePaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        /// <summary>
        /// Your (additional) reference identifier for this transaction. Data supplied in this property will also be returned in our report files, allowing you to reconcile the incoming funds.
        /// </summary>
        public string AdditionalReference { get; set; } = null;
    }
}
