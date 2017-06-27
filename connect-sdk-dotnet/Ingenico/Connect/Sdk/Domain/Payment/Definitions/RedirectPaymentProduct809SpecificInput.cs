/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentProduct809SpecificInput
    {
        [ObsoleteAttribute("Use RedirectPaymentMethodSpecificInput.expirationPeriod instead")]
        public string ExpirationPeriod { get; set; } = null;

        public string IssuerId { get; set; } = null;
    }
}
