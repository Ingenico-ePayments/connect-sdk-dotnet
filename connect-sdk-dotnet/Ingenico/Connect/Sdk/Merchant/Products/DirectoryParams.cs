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
    /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__products__paymentProductId__directory_get">Get payment product directory</a>
    /// </summary>
    public class DirectoryParams : AbstractParamRequest
    {
        public string CountryCode { get; set; } = null;

        public string CurrencyCode { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            AddParameter(result, "countryCode", CountryCode);
            AddParameter(result, "currencyCode", CurrencyCode);
            return result;
        }
    }
}
