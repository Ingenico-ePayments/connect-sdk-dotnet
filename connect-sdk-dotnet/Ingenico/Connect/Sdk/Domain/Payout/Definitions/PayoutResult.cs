/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PayoutResult">PayoutResult</a>
    /// </summary>
    public class PayoutResult : AbstractOrderStatus
    {
        public OrderOutput PayoutOutput { get; set; } = null;

        public string Status { get; set; } = null;

        public OrderStatusOutput StatusOutput { get; set; } = null;
    }
}
