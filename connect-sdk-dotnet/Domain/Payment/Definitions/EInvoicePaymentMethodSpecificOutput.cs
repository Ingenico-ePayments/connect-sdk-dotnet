/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class EInvoicePaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Object containing the results of the fraud screening
        /// </summary>
        public FraudResults FraudResults { get; set; } = null;

        /// <summary>
        /// AfterPay Installments (payment product 9000) specific details
        /// </summary>
        public EInvoicePaymentProduct9000SpecificOutput PaymentProduct9000SpecificOutput { get; set; } = null;
    }
}
