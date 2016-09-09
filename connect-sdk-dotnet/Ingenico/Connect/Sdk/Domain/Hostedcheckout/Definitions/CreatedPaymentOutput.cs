/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CreatedPaymentOutput">CreatedPaymentOutput</a>
    /// </summary>
    public class CreatedPaymentOutput
    {
        public DisplayedData DisplayedData { get; set; } = null;

        public Payment.Definitions.Payment Payment { get; set; } = null;

        public PaymentCreationReferences PaymentCreationReferences { get; set; } = null;

        public string PaymentStatusCategory { get; set; } = null;

        public string Tokens { get; set; } = null;
    }
}
