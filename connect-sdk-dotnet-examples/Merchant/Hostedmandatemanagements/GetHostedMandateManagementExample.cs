/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement;

namespace Ingenico.Connect.Sdk.Merchant.Hostedmandatemanagements
{
    public class GetHostedMandateManagementExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                GetHostedMandateManagementResponse response = await client.Merchant("merchantId").Hostedmandatemanagements().Get("hostedMandateManagementId");
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
