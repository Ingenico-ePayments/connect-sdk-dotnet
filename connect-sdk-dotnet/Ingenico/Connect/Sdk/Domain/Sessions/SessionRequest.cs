/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Sessions.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Sessions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_SessionRequest">SessionRequest</a>
    /// </summary>
    public class SessionRequest
    {
        public PaymentProductFiltersClientSession PaymentProductFilters { get; set; } = null;

        public IList<string> Tokens { get; set; } = null;
    }
}
