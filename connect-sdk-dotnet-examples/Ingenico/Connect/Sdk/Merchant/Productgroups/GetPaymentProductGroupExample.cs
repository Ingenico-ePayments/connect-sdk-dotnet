/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Product;
using Ingenico.Connect.Sdk.Merchant.Productgroups;

namespace Ingenico.Connect.Sdk.Merchant.Productgroups
{
    public class GetPaymentProductGroupExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                GetProductgroupParams query = new GetProductgroupParams();
                query.Amount = 1000L;
                query.IsRecurring = true;
                query.CountryCode = "NL";
                query.Locale = "en_US";
                query.CurrencyCode = "EUR";
                query.AddHide("fields");

                PaymentProductGroupResponse response = await client.Merchant("merchantId").Productgroups().Get("cards", query);
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
