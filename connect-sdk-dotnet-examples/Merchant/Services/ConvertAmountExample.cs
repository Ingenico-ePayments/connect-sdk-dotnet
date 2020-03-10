/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Services;
using Ingenico.Connect.Sdk.Merchant.Services;

namespace Ingenico.Connect.Sdk.Merchant.Services
{
    public class ConvertAmountExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                ConvertAmountParams query = new ConvertAmountParams();
                query.Source = "EUR";
                query.Target = "USD";
                query.Amount = 100L;

                ConvertAmount response = await client.Merchant("merchantId").Services().ConvertAmount(query);
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
