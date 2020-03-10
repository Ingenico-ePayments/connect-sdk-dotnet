/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Payout;

namespace Ingenico.Connect.Sdk.Merchant.Payouts
{
    public class ApprovePayoutExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                ApprovePayoutRequest body = new ApprovePayoutRequest();
                body.DatePayout = "20150102";

                PayoutResponse response = await client.Merchant("merchantId").Payouts().Approve("payoutId", body);
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
