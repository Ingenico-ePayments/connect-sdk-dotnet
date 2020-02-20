/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Product;
using System.Collections.Generic;
using KeyValuePair = Ingenico.Connect.Sdk.Domain.Definitions.KeyValuePair;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    public class GetCustomerDetailsExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                IList<KeyValuePair> values = new List<KeyValuePair>();

                KeyValuePair value1 = new KeyValuePair();
                value1.Key = "fiscalNumber";
                value1.Value = "01234567890";

                values.Add(value1);

                GetCustomerDetailsRequest body = new GetCustomerDetailsRequest();
                body.CountryCode = "SE";
                body.Values = values;

                GetCustomerDetailsResponse response = await client.Merchant("merchantId").Products().CustomerDetails(9000, body);
            }
#pragma warning restore 0168
        }

        private Client GetClient()
        {
            string apiKeyId = "someKey";
            string secretApiKey = "someSecret";

            CommunicatorConfiguration configuration = Factory.CreateConfiguration(apiKeyId, secretApiKey);
            return Factory.CreateClient(configuration);
        }
    }
}
