/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentOutput">PaymentOutput</a>
    /// </summary>
    public class PaymentOutput : OrderOutput
    {
        public long? AmountPaid { get; set; } = null;

        public BankTransferPaymentMethodSpecificOutput BankTransferPaymentMethodSpecificOutput { get; set; } = null;

        public CardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; } = null;

        public CashPaymentMethodSpecificOutput CashPaymentMethodSpecificOutput { get; set; } = null;

        public NonSepaDirectDebitPaymentMethodSpecificOutput DirectDebitPaymentMethodSpecificOutput { get; set; } = null;

        public InvoicePaymentMethodSpecificOutput InvoicePaymentMethodSpecificOutput { get; set; } = null;

        public string PaymentMethod { get; set; } = null;

        public RedirectPaymentMethodSpecificOutput RedirectPaymentMethodSpecificOutput { get; set; } = null;

        public SepaDirectDebitPaymentMethodSpecificOutput SepaDirectDebitPaymentMethodSpecificOutput { get; set; } = null;
    }
}
