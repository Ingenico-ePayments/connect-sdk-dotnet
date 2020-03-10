/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Product;
using Ingenico.Connect.Sdk.Merchant.Products;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    public class GetDirectoryExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                DirectoryParams query = new DirectoryParams();
                query.CountryCode = "NL";
                query.CurrencyCode = "EUR";

                Directory response = await client.Merchant("merchantId").Products().Directory(809, query);
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
