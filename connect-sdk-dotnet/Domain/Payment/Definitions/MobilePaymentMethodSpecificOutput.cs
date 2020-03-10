/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class MobilePaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        public string AuthorisationCode { get; set; } = null;

        public CardFraudResults FraudResults { get; set; } = null;

        public string Network { get; set; } = null;

        public MobilePaymentData PaymentData { get; set; } = null;

        public ThreeDSecureResults ThreeDSecureResults { get; set; } = null;
    }
}
