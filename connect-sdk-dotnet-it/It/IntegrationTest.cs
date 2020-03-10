using System;

namespace Ingenico.Connect.Sdk.It
{
    public abstract class IntegrationTest
    {
        protected CommunicatorConfiguration GetCommunicatorConfiguration()
        {
            if (ApiKeyId != null && SecretApiKey != null)
            {
                return Factory.CreateConfiguration(ApiKeyId, SecretApiKey);
            }
            throw new System.InvalidOperationException("Environment variables connect_api_apiKeyId and connect_api_secretApiKey must be set");
        }

        readonly string ApiKeyId = Environment.GetEnvironmentVariable("connect_api_apiKeyId");
        readonly string SecretApiKey = Environment.GetEnvironmentVariable("connect_api_secretApiKey");
        readonly string MerchantId = Environment.GetEnvironmentVariable("connect_api_merchantId");

        protected Client GetClient()
        {
            if (ApiKeyId != null && SecretApiKey != null)
            {
                return Factory.CreateClient(ApiKeyId, SecretApiKey).WithClientMetaInfo("{\"test\":\"test\"}");
            }
            throw new System.InvalidOperationException("Environment variables connect_api_apiKeyId and connect_api_secretApiKey must be set");
        }

        protected string GetMerchantId()
        {
            if (MerchantId != null)
            {
                return MerchantId;
            }
            throw new System.InvalidOperationException("Environment variable connect_api_merchantId must be set");
        }
    }
}
