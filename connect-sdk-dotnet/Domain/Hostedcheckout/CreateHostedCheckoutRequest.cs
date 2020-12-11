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
        /// <summary>
        /// Object containing the specific input details for bank transfer payments
        /// </summary>
        public BankTransferPaymentMethodSpecificInputBase BankTransferPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for card payments
        /// </summary>
        public CardPaymentMethodSpecificInputBase CardPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for cash payments
        /// </summary>
        public CashPaymentMethodSpecificInputBase CashPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for eInvoice payments
        /// </summary>
        public EInvoicePaymentMethodSpecificInputBase EInvoicePaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing additional data that will be used to assess the risk of fraud
        /// </summary>
        public FraudFields FraudFields { get; set; } = null;

        /// <summary>
        /// Object containing hosted checkout specific data
        /// </summary>
        public HostedCheckoutSpecificInput HostedCheckoutSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing information on you, the merchant
        /// </summary>
        public Payment.Definitions.Merchant Merchant { get; set; } = null;

        /// <summary>
        /// Object containing reference data for Google Pay (paymentProductId 320) and Apple Pay (paymentProductID 302).
        /// </summary>
        public MobilePaymentMethodSpecificInputHostedCheckout MobilePaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Order object containing order related data
        /// </summary>
        public Order Order { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for payments that involve redirects to 3rd parties to complete, like iDeal and PayPal
        /// </summary>
        public RedirectPaymentMethodSpecificInputBase RedirectPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for SEPA direct debit payments
        /// </summary>
        public SepaDirectDebitPaymentMethodSpecificInputBase SepaDirectDebitPaymentMethodSpecificInput { get; set; } = null;
    }
}
