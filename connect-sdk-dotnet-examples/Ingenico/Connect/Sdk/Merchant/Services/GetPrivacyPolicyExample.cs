/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Services;
using Ingenico.Connect.Sdk.Merchant.Services;

namespace Ingenico.Connect.Sdk.Merchant.Services
{
    public class GetPrivacyPolicyExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                PrivacypolicyParams query = new PrivacypolicyParams();
                query.Locale = "en_US";
                query.PaymentProductId = 771;

                GetPrivacyPolicyResponse response = await client.Merchant("merchantId").Services().Privacypolicy(query);
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
