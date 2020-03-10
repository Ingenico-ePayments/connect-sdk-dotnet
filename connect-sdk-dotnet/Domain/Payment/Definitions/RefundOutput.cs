/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RefundOutput : OrderOutput
    {
        public long? AmountPaid { get; set; } = null;

        public RefundBankMethodSpecificOutput BankRefundMethodSpecificOutput { get; set; } = null;

        public RefundCardMethodSpecificOutput CardRefundMethodSpecificOutput { get; set; } = null;

        public RefundCashMethodSpecificOutput CashRefundMethodSpecificOutput { get; set; } = null;

        public RefundEInvoiceMethodSpecificOutput EInvoiceRefundMethodSpecificOutput { get; set; } = null;

        public RefundEWalletMethodSpecificOutput EWalletRefundMethodSpecificOutput { get; set; } = null;

        public RefundMobileMethodSpecificOutput MobileRefundMethodSpecificOutput { get; set; } = null;

        public string PaymentMethod { get; set; } = null;
    }
}
