/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Newtonsoft.Json;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class RedirectDataBase
    {
        [JsonProperty(PropertyName = "RETURNMAC")]
        public string RETURNMAC { get; set; } = null;

        public string RedirectURL { get; set; } = null;
    }
}
