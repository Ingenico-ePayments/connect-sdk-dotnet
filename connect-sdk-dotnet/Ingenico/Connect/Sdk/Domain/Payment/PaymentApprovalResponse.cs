/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentApprovalResponse">PaymentApprovalResponse</a>
    /// </summary>
    public class PaymentApprovalResponse
    {
        public ApprovePaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; } = null;

        public ApprovePaymentMobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; } = null;

        public Definitions.Payment Payment { get; set; } = null;

        [ObsoleteAttribute("Use cardPaymentMethodSpecificOutput instead")]
        public ApprovePaymentCardPaymentMethodSpecificOutput PaymentMethodSpecificOutput { get; set; } = null;
    }
}
