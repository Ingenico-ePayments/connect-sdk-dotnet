/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class ApprovePaymentRequest
    {
        /// <summary>
        /// In case you want to approve the capture of a different lower amount you can specify this here (specified in cents, where single digit currencies are presumed to have 2 digits)
        /// </summary>
        public long? Amount { get; set; } = null;

        /// <summary>
        /// Object that holds non-SEPA Direct Debit specific input data
        /// </summary>
        public ApprovePaymentNonSepaDirectDebitPaymentMethodSpecificInput DirectDebitPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object that holds the order data
        /// </summary>
        public OrderApprovePayment Order { get; set; } = null;

        /// <summary>
        /// Object that holds SEPA Direct Debit specific input data
        /// </summary>
        public ApprovePaymentSepaDirectDebitPaymentMethodSpecificInput SepaDirectDebitPaymentMethodSpecificInput { get; set; } = null;
    }
}
