/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Merchant.Tokens;

namespace Ingenico.Connect.Sdk.Merchant.Tokens
{
    public class DeleteTokenExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                DeleteTokenParams query = new DeleteTokenParams();
                query.MandateCancelDate = "20150102";

                await client.Merchant("merchantId").Tokens().Delete("tokenId", query);
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
