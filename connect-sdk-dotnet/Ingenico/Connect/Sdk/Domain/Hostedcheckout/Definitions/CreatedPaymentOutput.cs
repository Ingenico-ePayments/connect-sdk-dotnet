/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class CreatedPaymentOutput
    {
        public DisplayedData DisplayedData { get; set; } = null;

        public Payment.Definitions.Payment Payment { get; set; } = null;

        public PaymentCreationReferences PaymentCreationReferences { get; set; } = null;

        [ObsoleteAttribute("Use Payment.statusOutput.statusCategory instead")]
        public string PaymentStatusCategory { get; set; } = null;

        public bool? TokenizationSucceeded { get; set; } = null;

        public string Tokens { get; set; } = null;
    }
}
