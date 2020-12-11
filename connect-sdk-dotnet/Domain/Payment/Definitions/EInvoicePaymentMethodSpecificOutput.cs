/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class EInvoicePaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// AfterPay Installments (payment product 9000) specific details
        /// </summary>
        public EInvoicePaymentProduct9000SpecificOutput PaymentProduct9000SpecificOutput { get; set; } = null;
    }
}
