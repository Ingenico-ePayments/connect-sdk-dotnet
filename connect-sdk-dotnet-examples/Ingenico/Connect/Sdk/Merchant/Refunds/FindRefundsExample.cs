/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Refund;
using Ingenico.Connect.Sdk.Merchant.Refunds;

namespace Ingenico.Connect.Sdk.Merchant.Refunds
{
    public class FindRefundsExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                FindRefundsParams query = new FindRefundsParams();
                query.HostedCheckoutId = "15c09dac-bf44-486a-af6b-edfd8680a166";
                query.MerchantReference = "AcmeOrder0001";
                query.MerchantOrderId = 123456L;
                query.Offset = 0;
                query.Limit = 10;

                FindRefundsResponse response = await client.Merchant("merchantId").Refunds().Find(query);
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
