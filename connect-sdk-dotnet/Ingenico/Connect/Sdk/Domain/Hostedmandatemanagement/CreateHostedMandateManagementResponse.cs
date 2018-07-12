/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Newtonsoft.Json;

namespace Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement
{
    public class CreateHostedMandateManagementResponse
    {
        [JsonProperty(PropertyName = "RETURNMAC")]
        public string RETURNMAC { get; set; } = null;

        public string HostedMandateManagementId { get; set; } = null;

        public string PartialRedirectUrl { get; set; } = null;
    }
}
