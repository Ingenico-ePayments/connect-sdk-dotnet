/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Services
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/services/convertAmount.html">Convert amount</a>
    /// </summary>
    public class ConvertAmountParams : AbstractParamRequest
    {
        public string Source { get; set; } = null;

        public string Target { get; set; } = null;

        public long? Amount { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            if (Source != null)
            {
                result.Add(new RequestParam("source", Source));
            }
            if (Target != null)
            {
                result.Add(new RequestParam("target", Target));
            }
            if (Amount != null)
            {
                result.Add(new RequestParam("amount", Amount.ToString()));
            }
            return result;
        }
    }
}
