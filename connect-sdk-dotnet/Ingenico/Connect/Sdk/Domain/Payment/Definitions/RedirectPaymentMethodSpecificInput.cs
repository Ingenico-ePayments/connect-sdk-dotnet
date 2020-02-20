/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentMethodSpecificInput : AbstractRedirectPaymentMethodSpecificInput
    {
        public bool? IsRecurring { get; set; } = null;

        public RedirectPaymentProduct809SpecificInput PaymentProduct809SpecificInput { get; set; } = null;

        public RedirectPaymentProduct816SpecificInput PaymentProduct816SpecificInput { get; set; } = null;

        public RedirectPaymentProduct840SpecificInput PaymentProduct840SpecificInput { get; set; } = null;

        public RedirectPaymentProduct861SpecificInput PaymentProduct861SpecificInput { get; set; } = null;

        public RedirectPaymentProduct863SpecificInput PaymentProduct863SpecificInput { get; set; } = null;

        public RedirectPaymentProduct869SpecificInput PaymentProduct869SpecificInput { get; set; } = null;

        public RedirectPaymentProduct882SpecificInput PaymentProduct882SpecificInput { get; set; } = null;

        public RedirectionData RedirectionData { get; set; } = null;

        [ObsoleteAttribute("Use redirectionData.returnUrl instead")]
        public string ReturnUrl { get; set; } = null;
    }
}
