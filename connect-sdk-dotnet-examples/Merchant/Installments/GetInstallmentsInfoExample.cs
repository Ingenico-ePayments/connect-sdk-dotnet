/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Installments;

namespace Ingenico.Connect.Sdk.Merchant.Installments
{
    public class GetInstallmentsInfoExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 123L;
                amountOfMoney.CurrencyCode = "EUR";

                GetInstallmentRequest body = new GetInstallmentRequest();
                body.AmountOfMoney = amountOfMoney;
                body.Bin = "123455";
                body.CountryCode = "NL";
                body.PaymentProductId = 123;

                InstallmentOptionsResponse response = await client.Merchant("merchantId").Installments().GetInstallmentsInfo(body);
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
