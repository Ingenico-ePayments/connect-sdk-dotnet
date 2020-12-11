/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class OrderStatusOutput
    {
        /// <summary>
        /// Custom object contains the set of errors
        /// </summary>
        public IList<APIError> Errors { get; set; } = null;

        /// <summary>
        /// Flag indicating if the payment can be cancelled 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsCancellable { get; set; } = null;

        /// <summary>
        /// Highlevel status of the payment, payout or refund with the following possible values: 
        /// <list type="bullet">
        ///   <item><description>CREATED - The transaction has been created. This is the initial state once a new payment, payout or refund is created. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>CREATED</description></item>
        ///   </list></description></item>
        ///   <item><description>PENDING_PAYMENT: The payment is waiting on customer action. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>PENDING_PAYMENT</description></item>
        ///     <item><description>REDIRECTED</description></item>
        ///   </list></description></item>
        ///   <item><description>ACCOUNT_VERIFIED: The account has been verified. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>ACCOUNT_VERIFIED</description></item>
        ///   </list></description></item>
        ///   <item><description>PENDING_MERCHANT: The transaction is awaiting approval to proceed with the payment, payout or refund. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>PENDING_APPROVAL</description></item>
        ///     <item><description>PENDING_COMPLETION</description></item>
        ///     <item><description>PENDING_CAPTURE</description></item>
        ///     <item><description>PENDING_FRAUD_APPROVAL</description></item>
        ///   </list></description></item>
        ///   <item><description>PENDING_CONNECT_OR_3RD_PARTY: The transaction is in the queue to be processed. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>AUTHORIZATION_REQUESTED</description></item>
        ///     <item><description>CAPTURE_REQUESTED</description></item>
        ///     <item><description>PAYOUT_REQUESTED</description></item>
        ///     <item><description>REFUND_REQUESTED</description></item>
        ///   </list></description></item>
        ///   <item><description>COMPLETED: The transaction has completed. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>CAPTURED</description></item>
        ///     <item><description>PAID</description></item>
        ///     <item><description>ACCOUNT_CREDITED</description></item>
        ///     <item><description>CHARGEBACK_NOTIFICATION</description></item>
        ///   </list></description></item>
        ///   <item><description>REVERSED: The transaction has been reversed. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>CHARGEBACKED</description></item>
        ///     <item><description>REVERSED</description></item>
        ///   </list></description></item>
        ///   <item><description>REFUNDED: The transaction has been refunded. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>REFUNDED</description></item>
        ///   </list></description></item>
        ///   <item><description>UNSUCCESSFUL: The transaction has been rejected or is in such a state that it will never become successful. This category groups the following statuses: 
        ///   <list type="bullet">
        ///     <item><description>CANCELLED</description></item>
        ///     <item><description>REJECTED</description></item>
        ///     <item><description>REJECTED_CAPTURE</description></item>
        ///     <item><description>REJECTED_CREDIT</description></item>
        ///   </list></description></item>
        /// </list>
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a> for a full overview of possible values.
        /// </summary>
        public string StatusCategory { get; set; } = null;

        /// <summary>
        /// Numeric status code of the legacy API. It is returned to ease the migration from the legacy APIs to Ingenico Connect. You should not write new business logic based on this property as it will be deprecated in a future version of the API. The value can also be found in the GlobalCollect Payment Console, in the Ogone BackOffice and in report files.
        /// </summary>
        public int? StatusCode { get; set; } = null;

        /// <summary>
        /// Date and time of payment
        /// <br />Format: YYYYMMDDHH24MISS
        /// </summary>
        public string StatusCodeChangeDateTime { get; set; } = null;
    }
}
