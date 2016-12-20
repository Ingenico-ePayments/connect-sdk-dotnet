/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__products__paymentProductId__networks_get">Get payment product networks</a>
    /// </summary>
    public class NetworksParams : AbstractParamRequest
    {
        public string CountryCode { get; set; } = null;

        public string CurrencyCode { get; set; } = null;

        public long? Amount { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            AddParameter(result, "countryCode", CountryCode);
            AddParameter(result, "currencyCode", CurrencyCode);
            AddParameter(result, "amount", Amount);
            AddParameter(result, "isRecurring", IsRecurring);
            return result;
        }
    }
}
