/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Services;

namespace Ingenico.Connect.Sdk.Merchant.Services
{
    public class ConvertBankAccountExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                BankAccountBban bankAccountBban = new BankAccountBban();
                bankAccountBban.AccountNumber = "0532013000";
                bankAccountBban.BankCode = "37040044";
                bankAccountBban.CountryCode = "DE";

                BankDetailsRequest body = new BankDetailsRequest();
                body.BankAccountBban = bankAccountBban;

                BankDetailsResponse response = await client.Merchant("merchantId").Services().Bankaccount(body);
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
