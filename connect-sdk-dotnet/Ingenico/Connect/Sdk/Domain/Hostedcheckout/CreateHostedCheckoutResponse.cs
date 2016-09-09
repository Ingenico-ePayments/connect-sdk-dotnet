/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Newtonsoft.Json;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CreateHostedCheckoutResponse">CreateHostedCheckoutResponse</a>
    /// </summary>
    public class CreateHostedCheckoutResponse
    {
        [JsonProperty(PropertyName = "RETURNMAC")]
        public string RETURNMAC { get; set; } = null;

        public string HostedCheckoutId { get; set; } = null;

        public string PartialRedirectUrl { get; set; } = null;
    }
}
