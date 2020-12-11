/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentProduct806SpecificOutput
    {
        /// <summary>
        /// Object containing the billing address details of the customer
        /// </summary>
        public Address BillingAddress { get; set; } = null;

        /// <summary>
        /// Object containing the account details
        /// </summary>
        public TrustlyBankAccount CustomerAccount { get; set; } = null;
    }
}
