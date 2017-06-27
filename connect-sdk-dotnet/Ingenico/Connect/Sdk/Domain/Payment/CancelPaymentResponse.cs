/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class CancelPaymentResponse
    {
        public CancelPaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; } = null;

        public CancelPaymentMobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; } = null;

        public Definitions.Payment Payment { get; set; } = null;
    }
}
