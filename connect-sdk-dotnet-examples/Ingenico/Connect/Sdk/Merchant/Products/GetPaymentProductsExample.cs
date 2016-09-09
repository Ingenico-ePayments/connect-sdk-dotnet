/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
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
                query.Amount = 1000L;
                query.IsRecurring = true;
                query.CountryCode = "US";
                query.Locale = "en_US";
                query.CurrencyCode = "USD";
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
