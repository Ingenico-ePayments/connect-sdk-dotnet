/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class MobilePaymentProduct320SpecificInputHostedCheckout
    {
        /// <summary>
        /// Used as an input for the Google Pay payment sheet. Provide your company name in a human readable form.
        /// </summary>
        public string MerchantName { get; set; } = null;

        /// <summary>
        /// Used as an input for the Google Pay payment sheet. Provide the url of your webshop. For international (non-ASCII) domains, please use 
        /// <a href="https://en.wikipedia.org/wiki/Punycode">Punycode</a>.
        /// </summary>
        public string MerchantOrigin { get; set; } = null;

        /// <summary>
        /// Object containing specific data regarding 3-D Secure
        /// </summary>
        public GPayThreeDSecure ThreeDSecure { get; set; } = null;
    }
}
