/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payout.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payout
{
    public class FindPayoutsResponse
    {
        /// <summary>
        /// The limit you used in the request.
        /// </summary>
        public int? Limit { get; set; } = null;

        /// <summary>
        /// The offset you used in the request.
        /// </summary>
        public int? Offset { get; set; } = null;

        /// <summary>
        /// A list of payouts that matched your filter, starting at the given offset and limited to the given limit.
        /// </summary>
        public IList<PayoutResult> Payouts { get; set; } = null;

        /// <summary>
        /// The total number of payouts that matched your filter.
        /// </summary>
        public int? TotalCount { get; set; } = null;
    }
}
