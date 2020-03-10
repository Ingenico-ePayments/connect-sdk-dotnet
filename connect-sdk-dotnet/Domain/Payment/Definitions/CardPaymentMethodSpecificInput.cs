/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CardPaymentMethodSpecificInput : AbstractCardPaymentMethodSpecificInput
    {
        public Card Card { get; set; } = null;

        [ObsoleteAttribute("Use threeDSecure.externalCardholderAuthenticationData instead")]
        public ExternalCardholderAuthenticationData ExternalCardholderAuthenticationData { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public string MerchantInitiatedReasonIndicator { get; set; } = null;

        [ObsoleteAttribute("Use threeDSecure.redirectionData.returnUrl instead")]
        public string ReturnUrl { get; set; } = null;

        public ThreeDSecure ThreeDSecure { get; set; } = null;
    }
}
