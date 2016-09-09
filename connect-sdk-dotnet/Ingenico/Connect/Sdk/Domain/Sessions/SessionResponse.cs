/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Sessions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_SessionResponse">SessionResponse</a>
    /// </summary>
    public class SessionResponse
    {
        public string ClientSessionId { get; set; } = null;

        public string CustomerId { get; set; } = null;

        public IList<string> InvalidTokens { get; set; } = null;

        public string Region { get; set; } = null;
    }
}
