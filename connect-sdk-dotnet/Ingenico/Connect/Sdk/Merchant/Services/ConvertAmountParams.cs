/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Services
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__services_convert_amount_get">Convert amount</a>
    /// </summary>
    public class ConvertAmountParams : AbstractParamRequest
    {
        public string Source { get; set; } = null;

        public string Target { get; set; } = null;

        public long? Amount { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            AddParameter(result, "source", Source);
            AddParameter(result, "target", Target);
            AddParameter(result, "amount", Amount);
            return result;
        }
    }
}
