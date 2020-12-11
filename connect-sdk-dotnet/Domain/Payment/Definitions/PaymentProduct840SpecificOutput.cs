/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentProduct840SpecificOutput
    {
        /// <summary>
        /// Object containing the billing address details of the customer
        /// </summary>
        public Address BillingAddress { get; set; } = null;

        /// <summary>
        /// Object containing the details of the PayPal account
        /// </summary>
        public PaymentProduct840CustomerAccount CustomerAccount { get; set; } = null;

        /// <summary>
        /// Object containing the address details of the customer
        /// </summary>
        public Address CustomerAddress { get; set; } = null;

        /// <summary>
        /// Protection Eligibility data of the PayPal customer
        /// </summary>
        public ProtectionEligibility ProtectionEligibility { get; set; } = null;
    }
}
