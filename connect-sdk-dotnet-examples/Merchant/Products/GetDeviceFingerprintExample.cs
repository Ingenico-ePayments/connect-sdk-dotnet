/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Product;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    public class GetDeviceFingerprintExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                DeviceFingerprintRequest body = new DeviceFingerprintRequest();

                DeviceFingerprintResponse response = await client.Merchant("merchantId").Products().DeviceFingerprint(1, body);
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
