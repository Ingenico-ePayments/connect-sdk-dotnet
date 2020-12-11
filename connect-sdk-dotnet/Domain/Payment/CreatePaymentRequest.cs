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
        /// <summary>
        /// Object containing the specific input details for bank transfer payments
        /// </summary>
        public BankTransferPaymentMethodSpecificInput BankTransferPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for card payments
        /// </summary>
        public CardPaymentMethodSpecificInput CardPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for cash payments
        /// </summary>
        public CashPaymentMethodSpecificInput CashPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for direct debit payments
        /// </summary>
        public NonSepaDirectDebitPaymentMethodSpecificInput DirectDebitPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for e-invoice payments.
        /// </summary>
        public EInvoicePaymentMethodSpecificInput EInvoicePaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Data that was encrypted client side containing all customer entered data elements like card data.
        /// <br />Note: Because this data can only be submitted once to our system and contains encrypted card data you should not store it. As the data was captured within the context of a client session you also need to submit it to us before the session has expired.
        /// </summary>
        public string EncryptedCustomerInput { get; set; } = null;

        /// <summary>
        /// Object containing additional data that will be used to assess the risk of fraud
        /// </summary>
        public FraudFields FraudFields { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for invoice payments
        /// </summary>
        public InvoicePaymentMethodSpecificInput InvoicePaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing information on you, the merchant
        /// </summary>
        public Definitions.Merchant Merchant { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for mobile payments. 
        /// <p>Mobile payments produce the required payment data in encrypted form.</p>
        /// <list type="bullet">
        ///   <item><description>For Apple Pay, the encrypted payment data can be found in property data of the 
        ///   <nobr>
        ///   <a href="https://developer.apple.com/documentation/passkit/pkpayment" target="_blank">PKPayment</a>.token.paymentData</nobr> property.</description></item>
        ///   <item><description>For Google Pay, the encrypted payment data can be found in property paymentMethodData.tokenizationData.token of the 
        ///   <nobr>
        ///   <a href="https://developers.google.com/android/reference/com/google/android/gms/wallet/PaymentData" target="_blank">PaymentData</a>.toJson()</nobr> result.</description></item>
        /// </list>
        /// </summary>
        public MobilePaymentMethodSpecificInput MobilePaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Order object containing order related data
        /// <br />Please note that this object is required to be able to submit the amount.
        /// </summary>
        public Order Order { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for payments that involve redirects to 3rd parties to complete, like iDeal and PayPal
        /// </summary>
        public RedirectPaymentMethodSpecificInput RedirectPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for SEPA direct debit payments
        /// </summary>
        public SepaDirectDebitPaymentMethodSpecificInput SepaDirectDebitPaymentMethodSpecificInput { get; set; } = null;
    }
}
