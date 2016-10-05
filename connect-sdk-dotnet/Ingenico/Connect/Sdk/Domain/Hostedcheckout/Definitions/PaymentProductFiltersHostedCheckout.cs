/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentProductFiltersHostedCheckout">PaymentProductFiltersHostedCheckout</a>
    /// </summary>
    public class PaymentProductFiltersHostedCheckout
    {
        public PaymentProductFilter Exclude { get; set; } = null;

        public PaymentProductFilter RestrictTo { get; set; } = null;

        public bool? TokensOnly { get; set; } = null;
    }
}
