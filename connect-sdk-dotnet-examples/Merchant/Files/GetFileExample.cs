/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System;
using System.IO;
using System.Threading;

namespace Ingenico.Connect.Sdk.Merchant.Files
{
    public class GetFileExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                await client.Merchant("merchantId").Files().GetFile("fileId", (stream, headers) => {
                    // Do something with stream and headers here.
                });

                // Note: no SynchronizationContext will be available inside the body handler.
                // Should your body handler need the current one, you need to capture it first:
                SynchronizationContext sc = SynchronizationContext.Current;
                await client.Merchant("merchantId").Files().GetFile("fileId", (stream, headers) => sc.Send(delegate {
                    // Do something with stream and headers here.
                }, null));
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
