/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class CreatedPaymentOutput
    {
        /// <summary>
        /// Object that contains the action, including the needed data, that you should perform next, like showing instruction, showing the transaction results or redirect to a third party to complete the payment
        /// </summary>
        public DisplayedData DisplayedData { get; set; } = null;

        /// <summary>
        /// Object that holds the payment data
        /// </summary>
        public Payment.Definitions.Payment Payment { get; set; } = null;

        /// <summary>
        /// Object containing the created references
        /// </summary>
        public PaymentCreationReferences PaymentCreationReferences { get; set; } = null;

        /// <summary>
        /// Highlevel indication of the payment status with the following possible values: 
        /// <list type="bullet">
        ///   <item><description>REJECTED - The payment has been rejected or is in such a state that it will never become successful. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>CREATED</description></item>
        ///     <item><description>REJECTED</description></item>
        ///     <item><description>REJECTED CAPTURE</description></item>
        ///     <item><description>REJECTED REFUND</description></item>
        ///     <item><description>REJECTED PAYOUT</description></item>
        ///     <item><description>CANCELLED</description></item>
        ///   </list></description></item>
        ///   <item><description>SUCCESSFUL - The payment was not (yet) rejected. Use the payment statuses to determine if it was completed, see 
        ///   <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a>. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>PENDING PAYMENT</description></item>
        ///     <item><description>ACCOUNT VERIFIED</description></item>
        ///     <item><description>PENDING FRAUD APPROVAL</description></item>
        ///     <item><description>PENDING APPROVAL</description></item>
        ///     <item><description>AUTHORIZATION REQUESTED</description></item>
        ///     <item><description>CAPTURE REQUESTED</description></item>
        ///     <item><description>REFUND REQUESTED</description></item>
        ///     <item><description>PAYOUT REQUESTED</description></item>
        ///     <item><description>CAPTURED</description></item>
        ///     <item><description>PAID</description></item>
        ///     <item><description>ACCOUNT CREDITED</description></item>
        ///     <item><description>REVERSED</description></item>
        ///     <item><description>CHARGEBACK_NOTIFICATION</description></item>
        ///     <item><description>CHARGEBACKED</description></item>
        ///     <item><description>REFUNDED</description></item>
        ///   </list></description></item>
        ///   <item><description>STATUS_UNKNOWN - The status of the payment is unknown at this moment. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>REDIRECTED</description></item>
        ///   </list></description></item>
        /// </list>
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a> for a full overview of possible values.
        /// </summary>
        [ObsoleteAttribute("Use Payment.statusOutput.statusCategory instead")]
        public string PaymentStatusCategory { get; set; } = null;

        /// <summary>
        /// If the payment was attempted to be tokenized, indicates if tokenization was successful or not.
        /// </summary>
        public bool? TokenizationSucceeded { get; set; } = null;

        /// <summary>
        /// This property contains the tokens that are associated with the hosted checkout session/customer. You can use the tokens listed in this list for a future checkout of the same customer.
        /// </summary>
        public string Tokens { get; set; } = null;
    }
}
