/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class MobilePaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string AuthorizationMode { get; set; } = null;

        public DecryptedPaymentData DecryptedPaymentData { get; set; } = null;

        public string EncryptedPaymentData { get; set; } = null;

        public bool? RequiresApproval { get; set; } = null;

        public bool? SkipFraudService { get; set; } = null;
    }
}
