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
            throw new System.InvalidOperationException("Environment variables connect.api.apiKeyId and connect.api.secretApiKey must be set");
        }

        string ApiKeyId = Environment.GetEnvironmentVariable("connect.api.apiKeyId");
        string SecretApiKey = Environment.GetEnvironmentVariable("connect.api.secretApiKey");

        protected Client GetClient()
        {
            if (ApiKeyId != null && SecretApiKey != null)
            {
                return Factory.CreateClient(ApiKeyId, SecretApiKey).WithClientMetaInfo("{\"test\":\"test\"}");
            }
            throw new System.InvalidOperationException("Environment variables connect.api.apiKeyId and connect.api.secretApiKey must be set");
        }
    }
}
