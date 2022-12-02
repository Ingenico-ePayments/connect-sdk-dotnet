/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Merchant
    {
        /// <summary>
        /// In case your account has been setup with multiple configurations you can use this property to identify the one you would like to use for the transaction. Note that you can only submit preconfigured values in combination with the Worldline Online Payments Acceptance platform. In case no value is supplied a default value of 0 will be submitted to the Worldline Online Payments Acceptance platform. The Worldline Online Payments Acceptance platform internally refers to this as a PosId.
        /// </summary>
        public string ConfigurationId { get; set; } = null;

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
