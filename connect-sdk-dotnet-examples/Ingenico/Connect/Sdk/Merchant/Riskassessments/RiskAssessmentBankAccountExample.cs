/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Riskassessments;
using Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions;

namespace Ingenico.Connect.Sdk.Merchant.Riskassessments
{
    public class RiskAssessmentBankAccountExample
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

                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.Amount = 100L;
                amountOfMoney.CurrencyCode = "EUR";

                Address billingAddress = new Address();
                billingAddress.CountryCode = "US";

                CustomerRiskAssessment customer = new CustomerRiskAssessment();
                customer.BillingAddress = billingAddress;
                customer.Locale = "en_US";

                OrderRiskAssessment order = new OrderRiskAssessment();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                RiskAssessmentBankAccount body = new RiskAssessmentBankAccount();
                body.BankAccountBban = bankAccountBban;
                body.Order = order;

                RiskAssessmentResponse response = await client.Merchant("merchantId").Riskassessments().Bankaccounts(body);
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
