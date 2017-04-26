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
    /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__products_get">Get payment products</a>
    /// </summary>
    public class FindProductsParams : AbstractParamRequest
    {
        public string CountryCode { get; set; } = null;

        public string CurrencyCode { get; set; } = null;

        public string Locale { get; set; } = null;

        public long? Amount { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public IList<string> Hide { get; set; } = null;

        public void AddHide(string value)
        {
            IList<string> hide = Hide;
            if (hide == null)
            {
                hide = new List<string>();
                Hide = hide;
            }
            hide.Add(value);
        }

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            AddParameter(result, "countryCode", CountryCode);
            AddParameter(result, "currencyCode", CurrencyCode);
            AddParameter(result, "locale", Locale);
            AddParameter(result, "amount", Amount);
            AddParameter(result, "isRecurring", IsRecurring);
            AddParameter(result, "hide", Hide);
            return result;
        }
    }
}
