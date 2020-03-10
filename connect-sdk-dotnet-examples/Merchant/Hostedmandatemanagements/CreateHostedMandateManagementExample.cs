/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement;
using Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement.Definitions;

namespace Ingenico.Connect.Sdk.Merchant.Hostedmandatemanagements
{
    public class CreateHostedMandateManagementExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                HostedMandateInfo createMandateInfo = new HostedMandateInfo();
                createMandateInfo.CustomerReference = "idonthaveareference";
                createMandateInfo.RecurrenceType = "RECURRING";
                createMandateInfo.SignatureType = "UNSIGNED";

                HostedMandateManagementSpecificInput hostedMandateManagementSpecificInput = new HostedMandateManagementSpecificInput();
                hostedMandateManagementSpecificInput.Locale = "fr_FR";
                hostedMandateManagementSpecificInput.ReturnUrl = "http://www.example.com";
                hostedMandateManagementSpecificInput.Variant = "101";

                CreateHostedMandateManagementRequest body = new CreateHostedMandateManagementRequest();
                body.CreateMandateInfo = createMandateInfo;
                body.HostedMandateManagementSpecificInput = hostedMandateManagementSpecificInput;

                CreateHostedMandateManagementResponse response = await client.Merchant("merchantId").Hostedmandatemanagements().Create(body);
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
