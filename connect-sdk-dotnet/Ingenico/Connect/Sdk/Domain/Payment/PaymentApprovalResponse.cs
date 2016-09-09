/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentApprovalResponse">PaymentApprovalResponse</a>
    /// </summary>
    public class PaymentApprovalResponse
    {
        public Definitions.Payment Payment { get; set; } = null;

        public ApprovePaymentCardPaymentMethodSpecificOutput PaymentMethodSpecificOutput { get; set; } = null;
    }
}
