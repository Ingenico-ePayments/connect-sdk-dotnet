/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Payment : AbstractOrderStatus
    {
        public HostedCheckoutSpecificOutput HostedCheckoutSpecificOutput { get; set; } = null;

        public PaymentOutput PaymentOutput { get; set; } = null;

        public string Status { get; set; } = null;

        public PaymentStatusOutput StatusOutput { get; set; } = null;
    }
}
