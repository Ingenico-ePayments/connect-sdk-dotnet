/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentMethodSpecificInput : RedirectPaymentMethodSpecificInputBase
    {
        public bool? IsRecurring { get; set; } = null;

        public RedirectPaymentProduct809SpecificInput PaymentProduct809SpecificInput { get; set; } = null;

        public RedirectPaymentProduct816SpecificInput PaymentProduct816SpecificInput { get; set; } = null;

        public RedirectPaymentProduct840SpecificInput PaymentProduct840SpecificInput { get; set; } = null;

        public RedirectPaymentProduct882SpecificInput PaymentProduct882SpecificInput { get; set; } = null;

        public string ReturnUrl { get; set; } = null;
    }
}
