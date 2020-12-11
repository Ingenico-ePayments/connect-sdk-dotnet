/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class EInvoicePaymentMethodSpecificInput : AbstractEInvoicePaymentMethodSpecificInput
    {
        /// <summary>
        /// Indicates that the customer has read and accepted the terms and conditions of the product before proceeding with the payment. This must be done before the payment can continue. An URL to the terms and conditions can be retrieved with 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/products/get.html">Get payment product</a>.
        /// </summary>
        public bool? AcceptedTermsAndConditions { get; set; } = null;

        /// <summary>
        /// Object that holds the specific data for AfterPay Installments (payment product 9000).
        /// </summary>
        public EInvoicePaymentProduct9000SpecificInput PaymentProduct9000SpecificInput { get; set; } = null;
    }
}
