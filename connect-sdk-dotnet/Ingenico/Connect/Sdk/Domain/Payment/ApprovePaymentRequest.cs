/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_ApprovePaymentRequest">ApprovePaymentRequest</a>
    /// </summary>
    public class ApprovePaymentRequest
    {
        public long? Amount { get; set; } = null;

        public ApprovePaymentNonSepaDirectDebitPaymentMethodSpecificInput DirectDebitPaymentMethodSpecificInput { get; set; } = null;

        public OrderApprovePayment Order { get; set; } = null;

        public ApprovePaymentSepaDirectDebitPaymentMethodSpecificInput SepaDirectDebitPaymentMethodSpecificInput { get; set; } = null;
    }
}
