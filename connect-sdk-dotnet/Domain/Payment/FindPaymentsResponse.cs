/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class FindPaymentsResponse
    {
        public int? Limit { get; set; } = null;

        public int? Offset { get; set; } = null;

        public IList<Definitions.Payment> Payments { get; set; } = null;

        public int? TotalCount { get; set; } = null;
    }
}
