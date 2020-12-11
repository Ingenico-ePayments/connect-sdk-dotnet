/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RefundOutput : OrderOutput
    {
        /// <summary>
        /// Amount paid
        /// </summary>
        public long? AmountPaid { get; set; } = null;

        /// <summary>
        /// Object containing specific bank refund details
        /// </summary>
        public RefundBankMethodSpecificOutput BankRefundMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing specific card refund details
        /// </summary>
        public RefundCardMethodSpecificOutput CardRefundMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing specific cash refund details
        /// </summary>
        public RefundCashMethodSpecificOutput CashRefundMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing specific e-invoice refund details
        /// </summary>
        public RefundEInvoiceMethodSpecificOutput EInvoiceRefundMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing specific eWallet refund details
        /// </summary>
        public RefundEWalletMethodSpecificOutput EWalletRefundMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing specific mobile refund details
        /// </summary>
        public RefundMobileMethodSpecificOutput MobileRefundMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Payment method identifier used by the our payment engine with the following possible values: 
        /// <list type="bullet">
        ///   <item><description>bankRefund</description></item>
        ///   <item><description>bankTransfer</description></item>
        ///   <item><description>card</description></item>
        ///   <item><description>cash</description></item>
        ///   <item><description>directDebit</description></item>
        ///   <item><description>eInvoice</description></item>
        ///   <item><description>invoice</description></item>
        ///   <item><description>redirect</description></item>
        /// </list>
        /// </summary>
        public string PaymentMethod { get; set; } = null;
    }
}
