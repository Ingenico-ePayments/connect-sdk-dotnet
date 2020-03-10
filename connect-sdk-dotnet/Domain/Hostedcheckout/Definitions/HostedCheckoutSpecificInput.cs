/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class HostedCheckoutSpecificInput
    {
        public bool? IsRecurring { get; set; } = null;

        public string Locale { get; set; } = null;

        public PaymentProductFiltersHostedCheckout PaymentProductFilters { get; set; } = null;

        public bool? ReturnCancelState { get; set; } = null;

        public string ReturnUrl { get; set; } = null;

        public bool? ShowResultPage { get; set; } = null;

        public string Tokens { get; set; } = null;

        public bool? ValidateShoppingCart { get; set; } = null;

        public string Variant { get; set; } = null;
    }
}
