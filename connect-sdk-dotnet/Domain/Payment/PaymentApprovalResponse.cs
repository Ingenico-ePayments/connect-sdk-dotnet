/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class PaymentApprovalResponse
    {
        /// <summary>
        /// Object containing additional card payment method specific details
        /// </summary>
        public ApprovePaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing additional mobile payment method specific details
        /// </summary>
        public ApprovePaymentMobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object that holds the payment data
        /// </summary>
        public Definitions.Payment Payment { get; set; } = null;

        /// <summary>
        /// Object containing additional payment method specific details
        /// <br />Deprecated: this property does not support different outputs for payment methods other than cards. Please use cardPaymentMethodSpecificOutput instead.
        /// </summary>
        [ObsoleteAttribute("Use cardPaymentMethodSpecificOutput instead")]
        public ApprovePaymentCardPaymentMethodSpecificOutput PaymentMethodSpecificOutput { get; set; } = null;
    }
}
