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
        public string CountryCode { get; set; } = null;

        public IList<KeyValuePair> Values { get; set; } = null;
    }
}
