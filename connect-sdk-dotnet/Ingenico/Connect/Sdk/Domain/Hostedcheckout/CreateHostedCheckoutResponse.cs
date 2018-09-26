/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout
{
    public class CreateHostedCheckoutResponse
    {
        [JsonProperty(PropertyName = "RETURNMAC")]
        public string RETURNMAC { get; set; } = null;

        public string HostedCheckoutId { get; set; } = null;

        public IList<string> InvalidTokens { get; set; } = null;

        public string MerchantReference { get; set; } = null;

        public string PartialRedirectUrl { get; set; } = null;
    }
}
