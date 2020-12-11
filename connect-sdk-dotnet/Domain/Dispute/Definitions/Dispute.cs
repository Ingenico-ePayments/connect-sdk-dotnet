/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Dispute.Definitions
{
    public class Dispute
    {
        /// <summary>
        /// This property contains the creationDetails and default information regarding a dispute.
        /// </summary>
        public DisputeOutput DisputeOutput { get; set; } = null;

        /// <summary>
        /// Dispute ID for a given merchant.
        /// </summary>
        public string Id { get; set; } = null;

        /// <summary>
        /// The ID of the payment that is being disputed.
        /// </summary>
        public string PaymentId { get; set; } = null;

        /// <summary>
        /// Current dispute status.
        /// </summary>
        public string Status { get; set; } = null;

        /// <summary>
        /// This property contains the output for a dispute regarding the status of the dispute.
        /// </summary>
        public DisputeStatusOutput StatusOutput { get; set; } = null;
    }
}
