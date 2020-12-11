/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Payment : AbstractOrderStatus
    {
        /// <summary>
        /// Hosted Checkout specific information. Populated if the payment was created on the GlobalCollect platform through a Hosted Checkout.
        /// </summary>
        public HostedCheckoutSpecificOutput HostedCheckoutSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object containing payment details
        /// </summary>
        public PaymentOutput PaymentOutput { get; set; } = null;

        /// <summary>
        /// Current high-level status of the payment in a human-readable form. Possible values are : 
        /// <list type="bullet">
        ///   <item><description>ACCOUNT_VERIFIED - The account has been verified using a validation services like 0$ auth</description></item>
        ///   <item><description>CREATED - The transaction has been created. This is the initial state once a new payment is created.</description></item>
        ///   <item><description>REDIRECTED - The customer has been redirected to a 3rd party to complete the authentication/payment</description></item>
        ///   <item><description>PENDING_PAYMENT - Instructions have been provided and we are now waiting for the money to come in</description></item>
        ///   <item><description>PENDING_FRAUD_APPROVAL - The transaction has been marked for manual review after an automatic fraud screening</description></item>
        ///   <item><description>PENDING_APPROVAL - The transaction is awaiting approval from you to proceed with the capturing of the funds</description></item>
        ///   <item><description>PENDING_COMPLETION - The transaction needs to be completed.</description></item>
        ///   <item><description>PENDING_CAPTURE - The transaction is waiting for you to request one or more captures of the funds.</description></item>
        ///   <item><description>REJECTED - The transaction has been rejected</description></item>
        ///   <item><description>AUTHORIZATION_REQUESTED - we have requested an authorization against an asynchronous system and is awaiting its response</description></item>
        ///   <item><description>CAPTURE_REQUESTED - The transaction is in the queue to be captured</description></item>
        ///   <item><description>CAPTURED - The transaction has been captured and we have received online confirmation</description></item>
        ///   <item><description>PAID - We have matched the incoming funds to the transaction</description></item>
        ///   <item><description>CANCELLED - You have cancelled the transaction</description></item>
        ///   <item><description>REJECTED_CAPTURE - We or one of our downstream acquirers/providers have rejected the capture request</description></item>
        ///   <item><description>REVERSED - The transaction has been reversed</description></item>
        ///   <item><description>CHARGEBACK_NOTIFICATION - We have received a notification of chargeback and this status informs you that your account will be debited for a particular transaction</description></item>
        ///   <item><description>CHARGEBACKED - The transaction has been chargebacked</description></item>
        ///   <item><description>REFUNDED - The transaction has been refunded</description></item>
        /// </list>
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a> for a full overview of possible values.
        /// </summary>
        public string Status { get; set; } = null;

        /// <summary>
        /// This object has the numeric representation of the current payment status, timestamp of last status change and performable action on the current payment resource. In case of failed payments and negative scenarios, detailed error information is listed.
        /// </summary>
        public PaymentStatusOutput StatusOutput { get; set; } = null;
    }
}
