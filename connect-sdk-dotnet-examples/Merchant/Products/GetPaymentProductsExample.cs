/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Product;
using Ingenico.Connect.Sdk.Merchant.Products;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    public class GetPaymentProductsExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                FindProductsParams query = new FindProductsParams();
                query.CountryCode = "US";
                query.CurrencyCode = "USD";
                query.Locale = "en_US";
                query.Amount = 1000L;
                query.IsRecurring = true;
                query.AddHide("fields");

                PaymentProducts response = await client.Merchant("merchantId").Products().Find(query);
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
