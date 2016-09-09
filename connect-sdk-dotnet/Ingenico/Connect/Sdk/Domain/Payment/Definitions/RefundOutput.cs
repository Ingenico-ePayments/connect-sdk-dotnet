/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_RefundOutput">RefundOutput</a>
    /// </summary>
    public class RefundOutput : OrderOutput
    {
        public long? AmountPaid { get; set; } = null;

        public RefundBankMethodSpecificOutput BankRefundMethodSpecificOutput { get; set; } = null;

        public RefundCardMethodSpecificOutput CardRefundMethodSpecificOutput { get; set; } = null;

        public RefundEWalletMethodSpecificOutput EWalletRefundMethodSpecificOutput { get; set; } = null;

        public string PaymentMethod { get; set; } = null;
    }
}
