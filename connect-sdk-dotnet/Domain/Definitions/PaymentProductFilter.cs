/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class PaymentProductFilter
    {
        /// <summary>
        /// List containing all payment product groups that should either be restricted to in or excluded from the payment context. Currently, there is only one group, called 'cards'.
        /// </summary>
        public IList<string> Groups { get; set; } = null;

        /// <summary>
        /// List containing all payment product ids that should either be restricted to in or excluded from the payment context.
        /// </summary>
        public IList<int?> Products { get; set; } = null;
    }
}
