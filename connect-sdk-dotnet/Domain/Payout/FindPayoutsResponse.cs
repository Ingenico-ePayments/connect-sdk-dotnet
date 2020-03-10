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
        public int? Limit { get; set; } = null;

        public int? Offset { get; set; } = null;

        public IList<PayoutResult> Payouts { get; set; } = null;

        public int? TotalCount { get; set; } = null;
    }
}
