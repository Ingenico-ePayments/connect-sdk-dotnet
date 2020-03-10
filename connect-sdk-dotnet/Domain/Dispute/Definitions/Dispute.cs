/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Dispute.Definitions
{
    public class Dispute
    {
        public DisputeOutput DisputeOutput { get; set; } = null;

        public string Id { get; set; } = null;

        public string PaymentId { get; set; } = null;

        public string Status { get; set; } = null;

        public DisputeStatusOutput StatusOutput { get; set; } = null;
    }
}
