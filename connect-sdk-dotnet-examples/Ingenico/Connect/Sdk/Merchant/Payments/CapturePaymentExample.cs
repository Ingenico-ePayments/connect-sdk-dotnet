/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Capture;
using Ingenico.Connect.Sdk.Domain.Payment;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    public class CapturePaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                CapturePaymentRequest body = new CapturePaymentRequest();
                body.Amount = 2980L;

                CaptureResponse response = await client.Merchant("merchantId").Payments().Capture("paymentId", body);
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
