/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    public class CompletePaymentExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                CardWithoutCvv card = new CardWithoutCvv();
                card.CardNumber = "67030000000000003";
                card.CardholderName = "Wile E. Coyote";
                card.ExpiryDate = "1220";

                CompletePaymentCardPaymentMethodSpecificInput cardPaymentMethodSpecificInput = new CompletePaymentCardPaymentMethodSpecificInput();
                cardPaymentMethodSpecificInput.Card = card;

                CompletePaymentRequest body = new CompletePaymentRequest();
                body.CardPaymentMethodSpecificInput = cardPaymentMethodSpecificInput;

                CompletePaymentResponse response = await client.Merchant("merchantId").Payments().Complete("paymentId", body);
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
