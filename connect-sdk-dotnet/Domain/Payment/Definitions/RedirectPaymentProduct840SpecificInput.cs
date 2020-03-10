/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentProduct840SpecificInput : AbstractRedirectPaymentProduct840SpecificInput
    {
        [ObsoleteAttribute("Use Order.references.descriptor instead")]
        public string Custom { get; set; } = null;

        public bool? IsShortcut { get; set; } = null;
    }
}
