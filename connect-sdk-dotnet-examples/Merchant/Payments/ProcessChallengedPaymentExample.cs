/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Payment;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    public class ProcessChallengedPaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                PaymentResponse response = await client.Merchant("merchantId").Payments().Processchallenged("paymentId");
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
