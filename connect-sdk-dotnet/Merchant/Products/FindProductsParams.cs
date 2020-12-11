/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/products/find.html">Get payment products</a>
    /// </summary>
    public class FindProductsParams : AbstractParamRequest
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code
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
        /// Amount in cents and always having 2 decimals
        /// </summary>
        public long? Amount { get; set; } = null;

        /// <summary>
        /// This allows you to filter payment products based on their support for recurring or not 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>If this is omitted all payment products are returned.
        /// </summary>
        public bool? IsRecurring { get; set; } = null;

        /// <summary>
        /// Allows you to hide elements from the response, reducing the amount of data that needs to be returned to your client. Possible options are: 
        /// <list type="bullet">
        ///   <item><description>fields - Don't return any data on fields of the payment product</description></item>
        ///   <item><description>accountsOnFile - Don't return any accounts on file data</description></item>
        ///   <item><description>translations - Don't return any label texts associated with the payment products</description></item>
        ///   <item><description>productsWithoutFields - Don't return products that require any additional data to be captured</description></item>
        ///   <item><description>productsWithoutInstructions - Don't return products that show instructions</description></item>
        ///   <item><description>productsWithRedirects - Don't return products that require a redirect to a 3rd party. Note that products that involve potential redirects related to 3D Secure authentication are not hidden</description></item>
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
