/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class MobilePaymentMethodSpecificInputHostedCheckout : AbstractPaymentMethodSpecificInput
    {
        /// <summary>
        /// Determines the type of the authorization that will be used. Allowed values: 
        /// <list type="bullet">
        ///   <item><description>FINAL_AUTHORIZATION - The payment creation results in an authorization that is ready for capture. Final authorizations can't be reversed and need to be captured for the full amount within 7 days.</description></item>
        ///   <item><description>PRE_AUTHORIZATION - The payment creation results in a pre-authorization that is ready for capture. Pre-authortizations can be reversed and can be captured within 30 days. The capture amount can be lower than the authorized amount.</description></item>
        ///   <item><description>SALE - The payment creation results in an authorization that is already captured at the moment of approval.</description></item>
        /// </list>Only used with some acquirers, ingnored for acquirers that don't support this. In case the acquirer doesn't allow this to be specified the authorizationMode is 'unspecified', which behaves similar to a final authorization.
        /// </summary>
        public string AuthorizationMode { get; set; } = null;

        /// <summary>
        /// Reference of the customer for the payment (purchase order #, etc.). Only used with some acquirers.
        /// </summary>
        public string CustomerReference { get; set; } = null;

        /// <summary>
        /// Object containing information specific to Apple Pay
        /// </summary>
        public MobilePaymentProduct302SpecificInputHostedCheckout PaymentProduct302SpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing information specific to Google Pay (paymentProductId 320)
        /// </summary>
        public MobilePaymentProduct320SpecificInputHostedCheckout PaymentProduct320SpecificInput { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true = the payment requires approval before the funds will be captured using the 
        ///   <a href='https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/approve.html'>Approve payment</a> or 
        ///   <a href='https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/capture.html'>Capture payment</a> API</description></item>
        ///   <item><description>false = the payment does not require approval, and the funds will be captured automatically</description></item>
        /// </list>
        /// </summary>
        public bool? RequiresApproval { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true = Fraud scoring will be skipped for this transaction</description></item>
        ///   <item><description>false = Fraud scoring will not be skipped for this transaction</description></item>
        /// </list>Note: This is only possible if your account in our system is setup for Fraud scoring and if your configuration in our system allows you to override it per transaction.
        /// </summary>
        public bool? SkipFraudService { get; set; } = null;
    }
}
