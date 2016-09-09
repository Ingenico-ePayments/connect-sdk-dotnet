/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Newtonsoft.Json;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_RedirectData">RedirectData</a>
    /// </summary>
    public class RedirectData
    {
        [JsonProperty(PropertyName = "RETURNMAC")]
        public string RETURNMAC { get; set; } = null;

        public string RedirectURL { get; set; } = null;
    }
}
