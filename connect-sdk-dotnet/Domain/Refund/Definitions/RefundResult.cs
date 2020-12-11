/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund.Definitions
{
    public class RefundResult : AbstractOrderStatus
    {
        /// <summary>
        /// Object containing refund details
        /// </summary>
        public RefundOutput RefundOutput { get; set; } = null;

        /// <summary>
        /// Current high-level status of the refund in a human-readable form. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>CREATED - The transaction has been created. This is the initial state once a new refund is created.</description></item>
        ///   <item><description>PENDING_APPROVAL - The transaction is awaiting approval from you to proceed with the processing of the refund</description></item>
        ///   <item><description>REJECTED - The refund has been rejected</description></item>
        ///   <item><description>REFUND_REQUESTED - The transaction is in the queue to be refunded</description></item>
        ///   <item><description>REFUNDED - We have successfully refunded the customer</description></item>
        ///   <item><description>REJECTED_CAPTURE - The refund was rejected by the bank or us during processing</description></item>
        ///   <item><description>CANCELLED - You have cancelled the transaction</description></item>
        /// </list>
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a> for a full overview of possible values.
        /// </summary>
        public string Status { get; set; } = null;

        /// <summary>
        /// This object has the numeric representation of the current refund status, timestamp of last status change and performable action on the current refund resource.
        /// <br />In case of a rejected refund, detailed error information is listed.
        /// </summary>
        public OrderStatusOutput StatusOutput { get; set; } = null;
    }
}
