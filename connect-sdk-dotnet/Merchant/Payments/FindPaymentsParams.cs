/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/find.html">Find payments</a>
    /// </summary>
    public class FindPaymentsParams : AbstractParamRequest
    {
        public string HostedCheckoutId { get; set; } = null;

        public string MerchantReference { get; set; } = null;

        public long? MerchantOrderId { get; set; } = null;

        public int? Offset { get; set; } = null;

        public int? Limit { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            if (HostedCheckoutId != null)
            {
                result.Add(new RequestParam("hostedCheckoutId", HostedCheckoutId));
            }
            if (MerchantReference != null)
            {
                result.Add(new RequestParam("merchantReference", MerchantReference));
            }
            if (MerchantOrderId != null)
            {
                result.Add(new RequestParam("merchantOrderId", MerchantOrderId.ToString()));
            }
            if (Offset != null)
            {
                result.Add(new RequestParam("offset", Offset.ToString()));
            }
            if (Limit != null)
            {
                result.Add(new RequestParam("limit", Limit.ToString()));
            }
            return result;
        }
    }
}
