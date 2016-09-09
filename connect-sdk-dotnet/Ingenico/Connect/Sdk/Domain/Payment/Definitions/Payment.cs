/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_Payment">Payment</a>
    /// </summary>
    public class Payment : AbstractOrderStatus
    {
        public PaymentOutput PaymentOutput { get; set; } = null;

        public string Status { get; set; } = null;

        public PaymentStatusOutput StatusOutput { get; set; } = null;
    }
}
