/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Sessions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Sessions
{
    public class CreateSessionExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                IList<string> tokens = new List<string>();
                tokens.Add("126166b16ed04b3ab85fb06da1d7a167");
                tokens.Add("226166b16ed04b3ab85fb06da1d7a167");
                tokens.Add("122c5b4d-dd40-49f0-b7c9-3594212167a9");
                tokens.Add("326166b16ed04b3ab85fb06da1d7a167");
                tokens.Add("426166b16ed04b3ab85fb06da1d7a167");

                SessionRequest body = new SessionRequest();
                body.Tokens = tokens;

                SessionResponse response = await client.Merchant("merchantId").Sessions().Create(body);
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
