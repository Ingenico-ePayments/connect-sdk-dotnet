/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Merchant
    {
        /// <summary>
        /// URL to find contact or support details to contact in case of questions.
        /// </summary>
        public string ContactWebsiteUrl { get; set; } = null;

        /// <summary>
        /// Object containing seller details
        /// </summary>
        public Seller Seller { get; set; } = null;

        /// <summary>
        /// The website from which the purchase was made
        /// </summary>
        public string WebsiteUrl { get; set; } = null;
    }
}
