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
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/services/privacypolicy.html">Get privacy policy</a>
    /// </summary>
    public class PrivacypolicyParams : AbstractParamRequest
    {
        /// <summary>
        /// Locale in which the privacy policy should be returned. Uses your default locale when none is provided.
        /// </summary>
        public string Locale { get; set; } = null;

        /// <summary>
        /// ID of the payment product for which you wish to retrieve the privacy policy. When no ID is provided you will receive all privacy policies for your payment products.
        /// </summary>
        public int? PaymentProductId { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            if (Locale != null)
            {
                result.Add(new RequestParam("locale", Locale));
            }
            if (PaymentProductId != null)
            {
                result.Add(new RequestParam("paymentProductId", PaymentProductId.ToString()));
            }
            return result;
        }
    }
}
