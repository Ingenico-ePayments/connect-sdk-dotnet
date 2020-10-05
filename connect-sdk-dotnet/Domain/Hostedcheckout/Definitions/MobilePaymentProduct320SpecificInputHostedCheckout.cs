/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class MobilePaymentProduct320SpecificInputHostedCheckout
    {
        public string MerchantName { get; set; } = null;

        public string MerchantOrigin { get; set; } = null;

        public GPayThreeDSecure ThreeDSecure { get; set; } = null;
    }
}
