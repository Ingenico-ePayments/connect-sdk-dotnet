/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Dispute;
using Ingenico.Connect.Sdk.Merchant.Disputes;
using System.IO;

namespace Ingenico.Connect.Sdk.Merchant.Disputes
{
    public class UploadDisputeFileExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                UploadFileRequest body = new UploadFileRequest();
                using (Stream fileContent = File.OpenRead("file.pdf"))
                {
                    body.File = new UploadableFile("file.pdf", fileContent, "application/pdf");

                    UploadDisputeFileResponse response = await client.Merchant("merchantId").Disputes().UploadFile("disputeId", body);
                }
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
