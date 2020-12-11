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
        /// <summary>
        /// Restrict the payment products available for payment completion by restricting to and excluding certain payment products and payment product groups.
        /// </summary>
        public PaymentProductFiltersClientSession PaymentProductFilters { get; set; } = null;

        /// <summary>
        /// List of previously stored tokens linked to the customer that wants to checkout.
        /// </summary>
        public IList<string> Tokens { get; set; } = null;
    }
}
