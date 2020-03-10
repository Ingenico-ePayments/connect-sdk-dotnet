/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Sessions
{
    public class SessionResponse
    {
        public string AssetUrl { get; set; } = null;

        public string ClientApiUrl { get; set; } = null;

        public string ClientSessionId { get; set; } = null;

        public string CustomerId { get; set; } = null;

        public IList<string> InvalidTokens { get; set; } = null;

        public string Region { get; set; } = null;
    }
}
