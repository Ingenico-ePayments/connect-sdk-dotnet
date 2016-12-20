/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_MobilePaymentMethodSpecificInput">MobilePaymentMethodSpecificInput</a>
    /// </summary>
    public class MobilePaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string AuthorizationMode { get; set; } = null;

        public DecryptedPaymentData DecryptedPaymentData { get; set; } = null;

        public string EncryptedPaymentData { get; set; } = null;

        public MobilePaymentProduct320SpecificInput PaymentProduct320SpecificInput { get; set; } = null;

        public bool? RequiresApproval { get; set; } = null;

        public bool? SkipFraudService { get; set; } = null;

        public string TransactionId { get; set; } = null;
    }
}
