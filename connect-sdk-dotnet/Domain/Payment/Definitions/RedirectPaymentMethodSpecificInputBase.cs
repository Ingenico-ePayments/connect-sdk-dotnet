/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentMethodSpecificInputBase : AbstractRedirectPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object containing specific input required for payment product 4101 (UPI)
        /// </summary>
        public RedirectPaymentProduct4101SpecificInputBase PaymentProduct4101SpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing specific input required for PayPal payments (Payment product ID 840)
        /// </summary>
        public RedirectPaymentProduct840SpecificInputBase PaymentProduct840SpecificInput { get; set; } = null;
    }
}
