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
        /// <summary>
        /// Object containing payout details
        /// </summary>
        public OrderOutput PayoutOutput { get; set; } = null;

        /// <summary>
        /// Current high-level status of the payouts in a human-readable form. Possible values are : 
        /// <list type="bullet">
        ///   <item><description>CREATED - The transaction has been created. This is the initial state once a new payout is created.</description></item>
        ///   <item><description>PENDING_APPROVAL - The transaction is awaiting approval from you to proceed with the paying out of the funds</description></item>
        ///   <item><description>REJECTED - The transaction has been rejected</description></item>
        ///   <item><description>PAYOUT_REQUESTED - The transaction is in the queue to be payed out to the customer</description></item>
        ///   <item><description>ACCOUNT_CREDITED - We have successfully credited the customer</description></item>
        ///   <item><description>REJECTED_CREDIT - The credit to the account of the customer was rejected by the bank</description></item>
        ///   <item><description>CANCELLED - You have cancelled the transaction</description></item>
        ///   <item><description>REVERSED - The payout has been reversed and the money is returned to your balance</description></item>
        /// </list>
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a> for a full overview of possible values.
        /// </summary>
        public string Status { get; set; } = null;

        /// <summary>
        /// This object has the numeric representation of the current payout status, timestamp of last status change and performable action on the current payout resource.
        /// <br />In case of a rejected payout, detailed error information is listed.
        /// </summary>
        public OrderStatusOutput StatusOutput { get; set; } = null;
    }
}
