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
        public ApprovePaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; } = null;

        public ApprovePaymentMobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; } = null;

        public Definitions.Payment Payment { get; set; } = null;

        [ObsoleteAttribute("Use cardPaymentMethodSpecificOutput instead")]
        public ApprovePaymentCardPaymentMethodSpecificOutput PaymentMethodSpecificOutput { get; set; } = null;
    }
}
