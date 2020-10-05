/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class MobilePaymentMethodSpecificInputHostedCheckout : AbstractPaymentMethodSpecificInput
    {
        public string AuthorizationMode { get; set; } = null;

        public string CustomerReference { get; set; } = null;

        public MobilePaymentProduct302SpecificInputHostedCheckout PaymentProduct302SpecificInput { get; set; } = null;

        public MobilePaymentProduct320SpecificInputHostedCheckout PaymentProduct320SpecificInput { get; set; } = null;

        public bool? RequiresApproval { get; set; } = null;

        public bool? SkipFraudService { get; set; } = null;
    }
}
