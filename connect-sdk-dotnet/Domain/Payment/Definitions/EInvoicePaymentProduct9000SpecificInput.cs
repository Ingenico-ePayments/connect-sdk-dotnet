/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class EInvoicePaymentProduct9000SpecificInput
    {
        /// <summary>
        /// Object containing the bank account details of the customer.
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;

        /// <summary>
        /// The ID of the installment plan selected by the customer. Installment plans can be retrieved with 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/products/get.html">Get payment product</a>.
        /// </summary>
        public string InstallmentId { get; set; } = null;
    }
}
