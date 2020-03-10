/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class PaymentProductFiltersHostedCheckout
    {
        public PaymentProductFilter Exclude { get; set; } = null;

        public PaymentProductFilter RestrictTo { get; set; } = null;

        public bool? TokensOnly { get; set; } = null;
    }
}
