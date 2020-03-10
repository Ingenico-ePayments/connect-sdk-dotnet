/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentOutput : OrderOutput
    {
        public long? AmountPaid { get; set; } = null;

        public long? AmountReversed { get; set; } = null;

        public BankTransferPaymentMethodSpecificOutput BankTransferPaymentMethodSpecificOutput { get; set; } = null;

        public CardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; } = null;

        public CashPaymentMethodSpecificOutput CashPaymentMethodSpecificOutput { get; set; } = null;

        public NonSepaDirectDebitPaymentMethodSpecificOutput DirectDebitPaymentMethodSpecificOutput { get; set; } = null;

        public EInvoicePaymentMethodSpecificOutput EInvoicePaymentMethodSpecificOutput { get; set; } = null;

        public InvoicePaymentMethodSpecificOutput InvoicePaymentMethodSpecificOutput { get; set; } = null;

        public MobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; } = null;

        public string PaymentMethod { get; set; } = null;

        public RedirectPaymentMethodSpecificOutput RedirectPaymentMethodSpecificOutput { get; set; } = null;

        public SepaDirectDebitPaymentMethodSpecificOutput SepaDirectDebitPaymentMethodSpecificOutput { get; set; } = null;
    }
}
