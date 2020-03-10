/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class EInvoicePaymentMethodSpecificInput : AbstractEInvoicePaymentMethodSpecificInput
    {
        public bool? AcceptedTermsAndConditions { get; set; } = null;

        public EInvoicePaymentProduct9000SpecificInput PaymentProduct9000SpecificInput { get; set; } = null;
    }
}
