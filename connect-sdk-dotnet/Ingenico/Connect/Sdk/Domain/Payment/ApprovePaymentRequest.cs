/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class ApprovePaymentRequest
    {
        public long? Amount { get; set; } = null;

        public ApprovePaymentNonSepaDirectDebitPaymentMethodSpecificInput DirectDebitPaymentMethodSpecificInput { get; set; } = null;

        public OrderApprovePayment Order { get; set; } = null;

        public ApprovePaymentSepaDirectDebitPaymentMethodSpecificInput SepaDirectDebitPaymentMethodSpecificInput { get; set; } = null;
    }
}
