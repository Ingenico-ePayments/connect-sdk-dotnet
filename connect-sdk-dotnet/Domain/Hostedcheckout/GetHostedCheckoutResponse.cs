/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout
{
    public class GetHostedCheckoutResponse
    {
        /// <summary>
        /// When a payment has been created during the hosted checkout session this object will return the details.
        /// </summary>
        public CreatedPaymentOutput CreatedPaymentOutput { get; set; } = null;

        /// <summary>
        /// This is the status of the hosted checkout. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>IN_PROGRESS - The checkout is still in progress and has not finished yet</description></item>
        ///   <item><description>PAYMENT_CREATED - A payment has been created</description></item>
        ///   <item><description>CANCELLED_BY_CONSUMER - If a customer cancels the payment on the payment product detail page of the MyCheckout hosted payment pages, the status will change to IN_PROGRESS. Since we understand you want to be aware of a customer cancelling the payment on the page we host for you, you can choose to receive the status CANCELLED_BY_CONSUMER instead of the status IN_PROGRESS. In order to receive the status CANCELLED_BY_CONSUMER, you need to have the returnCancelState flag enabled in the 
        ///   <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/hostedcheckouts/create.html">Create hosted checkout</a> call.</description></item>
        ///   <item><description>CLIENT_NOT_ELIGIBLE_FOR_SELECTED_PAYMENT_PRODUCT - With some payment products it might occur that the device of the user is not capable to complete the payment. If the Hosted Checkout Session was restricted to a single project that is not compatible to the user's device you will receive this Hosted Checkout status. This scenario applies to: Google Pay (Payment Product ID: 320).</description></item>
        /// </list>
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/statuses.html">Statuses</a> for a full overview of possible values.
        /// </summary>
        public string Status { get; set; } = null;
    }
}
