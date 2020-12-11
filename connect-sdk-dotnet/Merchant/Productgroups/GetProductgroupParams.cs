/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Productgroups
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/productgroups/get.html">Get payment product group</a>
    /// </summary>
    public class GetProductgroupParams : AbstractParamRequest
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the transaction
        /// </summary>
        public string CountryCode { get; set; } = null;

        /// <summary>
        /// Three-letter ISO currency code representing the currency for the amount
        /// </summary>
        public string CurrencyCode { get; set; } = null;

        /// <summary>
        /// Locale used in the GUI towards the consumer. Please make sure that a language pack is configured for the locale you are submitting. If you submit a locale that is not setup on your account we will use the default language pack for your account. You can easily upload additional language packs and set the default language pack in the Configuration Center.
        /// </summary>
        public string Locale { get; set; } = null;

        /// <summary>
        /// Amount of the transaction in cents and always having 2 decimals.
        /// </summary>
        public long? Amount { get; set; } = null;

        /// <summary>
        /// Toggles filtering on support for recurring payments. Default value is false. 
        /// <list type="bullet">
        ///   <item><description>true - filter out groups that do not support recurring payments, where a group supports recurring payments if it has at least one payment product that supports recurring.</description></item>
        ///   <item><description>false - do not filter</description></item>
        /// </list>
        /// </summary>
        public bool? IsRecurring { get; set; } = null;

        /// <summary>
        /// Allows you to hide elements from the response, reducing the amount of data that needs to be returned to your client. Possible options are: 
        /// <list type="bullet">
        ///   <item><description>fields - Don't return any data on fields of the payment product</description></item>
        ///   <item><description>accountsOnFile - Don't return any accounts on file data</description></item>
        ///   <item><description>translations - Don't return any label texts associated with the payment products</description></item>
        /// </list>
        /// </summary>
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
            if (CountryCode != null)
            {
                result.Add(new RequestParam("countryCode", CountryCode));
            }
            if (CurrencyCode != null)
            {
                result.Add(new RequestParam("currencyCode", CurrencyCode));
            }
            if (Locale != null)
            {
                result.Add(new RequestParam("locale", Locale));
            }
            if (Amount != null)
            {
                result.Add(new RequestParam("amount", Amount.ToString()));
            }
            if (IsRecurring != null)
            {
                result.Add(new RequestParam("isRecurring", IsRecurring.ToString().ToLower()));
            }
            if (Hide != null)
            {
                foreach (var hideElement in Hide)
                {
                    if (hideElement != null)
                    {
                        result.Add(new RequestParam("hide", hideElement));
                    }
                }
            }
            return result;
        }
    }
}
