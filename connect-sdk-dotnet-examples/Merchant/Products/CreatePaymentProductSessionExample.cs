/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Product;
using Ingenico.Connect.Sdk.Domain.Product.Definitions;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    public class CreatePaymentProductSessionExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                MobilePaymentProductSession302SpecificInput paymentProductSession302SpecificInput = new MobilePaymentProductSession302SpecificInput();
                paymentProductSession302SpecificInput.DisplayName = "Ingenico";
                paymentProductSession302SpecificInput.DomainName = "pay1.secured-by-ingenico.com";
                paymentProductSession302SpecificInput.ValidationUrl = "<VALIDATION URL RECEIVED FROM APPLE>";

                CreatePaymentProductSessionRequest body = new CreatePaymentProductSessionRequest();
                body.PaymentProductSession302SpecificInput = paymentProductSession302SpecificInput;

                CreatePaymentProductSessionResponse response = await client.Merchant("merchantId").Products().Sessions(302, body);
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
