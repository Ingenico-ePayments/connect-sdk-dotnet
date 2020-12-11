/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement.Definitions
{
    public class HostedMandateManagementSpecificInput
    {
        /// <summary>
        /// Locale to use to present the hosted mandate pages to the customer. Please make sure that a language pack is configured for the locale you are submitting. If you submit a locale that is not setup on your account we will use the default language pack for your account. You can easily upload additional language packs and set the default language pack in the Configuration Center.
        /// </summary>
        public string Locale { get; set; } = null;

        /// <summary>
        /// The URL that the customer is redirect to after the mandate flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the customer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process.
        /// <br />Note: The provided URL should be absolute and contain the protocol to use, e.g. http:// or https://. For use on mobile devices a custom protocol can be used in the form of 
        /// <i>protocol</i>://. This protocol must be registered on the device first.
        /// <br />URLs without a protocol will be rejected.
        /// </summary>
        public string ReturnUrl { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - MyMandate will show a result page to the customer when applicable. Default.</description></item>
        ///   <item><description>false - MyMandate will redirect the customer back to the provided returnUrl when this is possible.</description></item>
        /// </list>The default value for this property is true.
        /// </summary>
        public bool? ShowResultPage { get; set; } = null;

        /// <summary>
        /// The ID of the variant used to create the Hosted Mandate Management Session in which the payment was made.
        /// </summary>
        public string Variant { get; set; } = null;
    }
}
