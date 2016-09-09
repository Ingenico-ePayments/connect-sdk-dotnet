/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Token;

namespace Ingenico.Connect.Sdk.Merchant.Tokens
{
    public class ApproveSepaDirectDebitTokenExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                ApproveTokenRequest body = new ApproveTokenRequest();
                body.MandateSignatureDate = "20150201";
                body.MandateSignaturePlace = "Monument Valley";
                body.MandateSigned = true;

                await client.Merchant("merchantId").Tokens().Approvesepadirectdebit("tokenId", body);
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
