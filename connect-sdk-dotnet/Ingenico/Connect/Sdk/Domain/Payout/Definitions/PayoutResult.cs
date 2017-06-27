/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    public class PayoutResult : AbstractOrderStatus
    {
        public OrderOutput PayoutOutput { get; set; } = null;

        public string Status { get; set; } = null;

        public OrderStatusOutput StatusOutput { get; set; } = null;
    }
}
