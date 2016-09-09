/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_HostedCheckoutSpecificInput">HostedCheckoutSpecificInput</a>
    /// </summary>
    public class HostedCheckoutSpecificInput
    {
        public bool? IsRecurring { get; set; } = null;

        public string Locale { get; set; } = null;

        public string ReturnUrl { get; set; } = null;

        public bool? ShowResultPage { get; set; } = null;

        public string Tokens { get; set; } = null;

        public string Variant { get; set; } = null;
    }
}
