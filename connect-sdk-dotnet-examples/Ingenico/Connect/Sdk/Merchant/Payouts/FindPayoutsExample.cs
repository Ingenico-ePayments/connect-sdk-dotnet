/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Payout;
using Ingenico.Connect.Sdk.Merchant.Payouts;

namespace Ingenico.Connect.Sdk.Merchant.Payouts
{
    public class FindPayoutsExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                FindPayoutsParams query = new FindPayoutsParams();
                query.MerchantReference = "AcmeOrder0001";
                query.MerchantOrderId = 123456L;
                query.Offset = 0;
                query.Limit = 10;

                FindPayoutsResponse response = await client.Merchant("merchantId").Payouts().Find(query);
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
