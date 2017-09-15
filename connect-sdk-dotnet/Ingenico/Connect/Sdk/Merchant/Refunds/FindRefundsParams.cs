/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Refunds
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/refunds/find.html">Find refunds</a>
    /// </summary>
    public class FindRefundsParams : AbstractParamRequest
    {
        public string MerchantReference { get; set; } = null;

        public long? MerchantOrderId { get; set; } = null;

        public int? Offset { get; set; } = null;

        public int? Limit { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            AddParameter(result, "merchantReference", MerchantReference);
            AddParameter(result, "merchantOrderId", MerchantOrderId);
            AddParameter(result, "offset", Offset);
            AddParameter(result, "limit", Limit);
            return result;
        }
    }
}
