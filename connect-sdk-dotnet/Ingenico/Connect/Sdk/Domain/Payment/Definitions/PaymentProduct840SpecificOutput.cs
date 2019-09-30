/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentProduct840SpecificOutput
    {
        public Address BillingAddress { get; set; } = null;

        public PaymentProduct840CustomerAccount CustomerAccount { get; set; } = null;

        public Address CustomerAddress { get; set; } = null;

        public ProtectionEligibility ProtectionEligibility { get; set; } = null;
    }
}
