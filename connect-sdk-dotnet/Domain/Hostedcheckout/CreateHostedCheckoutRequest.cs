/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout
{
    public class CreateHostedCheckoutRequest
    {
        public BankTransferPaymentMethodSpecificInputBase BankTransferPaymentMethodSpecificInput { get; set; } = null;

        public CardPaymentMethodSpecificInputBase CardPaymentMethodSpecificInput { get; set; } = null;

        public CashPaymentMethodSpecificInputBase CashPaymentMethodSpecificInput { get; set; } = null;

        public EInvoicePaymentMethodSpecificInputBase EInvoicePaymentMethodSpecificInput { get; set; } = null;

        public FraudFields FraudFields { get; set; } = null;

        public HostedCheckoutSpecificInput HostedCheckoutSpecificInput { get; set; } = null;

        public Payment.Definitions.Merchant Merchant { get; set; } = null;

        public MobilePaymentMethodSpecificInputHostedCheckout MobilePaymentMethodSpecificInput { get; set; } = null;

        public Order Order { get; set; } = null;

        public RedirectPaymentMethodSpecificInputBase RedirectPaymentMethodSpecificInput { get; set; } = null;

        public SepaDirectDebitPaymentMethodSpecificInputBase SepaDirectDebitPaymentMethodSpecificInput { get; set; } = null;
    }
}
