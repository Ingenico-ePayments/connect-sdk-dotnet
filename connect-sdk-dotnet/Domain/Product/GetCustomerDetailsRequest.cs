/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;
using KeyValuePair = Ingenico.Connect.Sdk.Domain.Definitions.KeyValuePair;

namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class GetCustomerDetailsRequest
    {
        /// <summary>
        /// The code of the country where the customer should reside.
        /// </summary>
        public string CountryCode { get; set; } = null;

        /// <summary>
        /// A list of keys with a value used to retrieve the details of a customer. Depending on the country code, different keys are required. These can be determined with a getPaymentProduct call and using payment product properties with the property usedForLookup set to true.
        /// </summary>
        public IList<KeyValuePair> Values { get; set; } = null;
    }
}
