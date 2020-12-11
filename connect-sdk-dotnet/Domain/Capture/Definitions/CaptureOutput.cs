/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Capture.Definitions
{
    public class CaptureOutput : OrderOutput
    {
        /// <summary>
        /// Amount that has been paid
        /// </summary>
        public long? AmountPaid { get; set; } = null;

        /// <summary>
        /// Amount that has been reversed
        /// </summary>
        public long? AmountReversed { get; set; } = null;

        /// <summary>
        /// Object containing the bank transfer payment method details
        /// </summary>
        public BankTransferPaymentMethodSpecificOutput BankTransferPaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing the card payment method details
        /// </summary>
        public CardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing the cash payment method details
        /// </summary>
        public CashPaymentMethodSpecificOutput CashPaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing the non SEPA direct debit payment method details
        /// </summary>
        public NonSepaDirectDebitPaymentMethodSpecificOutput DirectDebitPaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing the e-invoice payment method details
        /// </summary>
        public EInvoicePaymentMethodSpecificOutput EInvoicePaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing the invoice payment method details
        /// </summary>
        public InvoicePaymentMethodSpecificOutput InvoicePaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing the mobile payment method details
        /// </summary>
        public MobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; } = null;

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

        /// <summary>
        /// Object containing the redirect payment product details
        /// </summary>
        public RedirectPaymentMethodSpecificOutput RedirectPaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// The reason description given for the reversedAmount property.
        /// </summary>
        public string ReversalReason { get; set; } = null;

        /// <summary>
        /// Object containing the SEPA direct debit details
        /// </summary>
        public SepaDirectDebitPaymentMethodSpecificOutput SepaDirectDebitPaymentMethodSpecificOutput { get; set; } = null;
    }
}
