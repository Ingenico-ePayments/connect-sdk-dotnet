/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class ContactDetailsBase
    {
        /// <summary>
        /// Email address of the customer
        /// </summary>
        public string EmailAddress { get; set; } = null;

        /// <summary>
        /// Preference for the type of email message markup 
        /// <list type="bullet">
        ///   <item><description>plain-text</description></item>
        ///   <item><description>html</description></item>
        /// </list>
        /// </summary>
        public string EmailMessageType { get; set; } = null;
    }
}
