/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CardPaymentMethodSpecificInput : CardPaymentMethodSpecificInputBase
    {
        public Card Card { get; set; } = null;

        public ExternalCardholderAuthenticationData ExternalCardholderAuthenticationData { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public string ReturnUrl { get; set; } = null;
    }
}
