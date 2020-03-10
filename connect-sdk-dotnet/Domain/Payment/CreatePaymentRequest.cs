/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class CreatePaymentRequest
    {
        public BankTransferPaymentMethodSpecificInput BankTransferPaymentMethodSpecificInput { get; set; } = null;

        public CardPaymentMethodSpecificInput CardPaymentMethodSpecificInput { get; set; } = null;

        public CashPaymentMethodSpecificInput CashPaymentMethodSpecificInput { get; set; } = null;

        public NonSepaDirectDebitPaymentMethodSpecificInput DirectDebitPaymentMethodSpecificInput { get; set; } = null;

        public EInvoicePaymentMethodSpecificInput EInvoicePaymentMethodSpecificInput { get; set; } = null;

        public string EncryptedCustomerInput { get; set; } = null;

        public FraudFields FraudFields { get; set; } = null;

        public InvoicePaymentMethodSpecificInput InvoicePaymentMethodSpecificInput { get; set; } = null;

        public Definitions.Merchant Merchant { get; set; } = null;

        public MobilePaymentMethodSpecificInput MobilePaymentMethodSpecificInput { get; set; } = null;

        public Order Order { get; set; } = null;

        public RedirectPaymentMethodSpecificInput RedirectPaymentMethodSpecificInput { get; set; } = null;

        public SepaDirectDebitPaymentMethodSpecificInput SepaDirectDebitPaymentMethodSpecificInput { get; set; } = null;
    }
}
