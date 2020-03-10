/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Services;

namespace Ingenico.Connect.Sdk.Merchant.Services
{
    public class IINDetailsExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                GetIINDetailsRequest body = new GetIINDetailsRequest();
                body.Bin = "4567350000427977";

                GetIINDetailsResponse response = await client.Merchant("merchantId").Services().GetIINdetails(body);
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
