/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Sessions.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Sessions
{
    public class SessionRequest
    {
        public PaymentProductFiltersClientSession PaymentProductFilters { get; set; } = null;

        public IList<string> Tokens { get; set; } = null;
    }
}
