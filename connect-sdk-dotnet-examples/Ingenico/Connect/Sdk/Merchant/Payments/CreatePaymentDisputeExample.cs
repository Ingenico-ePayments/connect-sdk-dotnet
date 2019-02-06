/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Dispute;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    public class CreatePaymentDisputeExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 1234L;
                amountOfMoney.CurrencyCode = "USD";

                CreateDisputeRequest body = new CreateDisputeRequest();
                body.AmountOfMoney = amountOfMoney;
                body.ContactPerson = "Wile Coyote";
                body.EmailAddress = "wile.e.coyote@acmelabs.com";
                body.ReplyTo = "r.runner@acmelabs.com";
                body.RequestMessage = "This is the message from the merchant to GlobalCollect. It is a a freeform text field.";

                DisputeResponse response = await client.Merchant("merchantId").Payments().Dispute("paymentId", body);
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
