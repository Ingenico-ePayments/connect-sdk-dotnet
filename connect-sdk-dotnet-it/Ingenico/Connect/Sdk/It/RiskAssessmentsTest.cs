using NUnit.Framework;
using Ingenico.Connect.Sdk.Domain.Riskassessments;
using Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions;
using Ingenico.Connect.Sdk.Domain.Definitions;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    public class RiskAssessmentsTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for risk assessments service.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            RiskAssessmentBankAccount body = new RiskAssessmentBankAccount();

            BankAccountBban bankAccountBban = new BankAccountBban();
            bankAccountBban.CountryCode = ("DE");
            bankAccountBban.AccountNumber = ("0532013000");
            bankAccountBban.BankCode = ("37040044");
            body.BankAccountBban = (bankAccountBban);

            OrderRiskAssessment order = new OrderRiskAssessment();

            AmountOfMoney amountOfMoney = new AmountOfMoney();
            amountOfMoney.Amount = (100L);
            amountOfMoney.CurrencyCode = ("EUR");
            order.AmountOfMoney = (amountOfMoney);

            CustomerRiskAssessment customer = new CustomerRiskAssessment();
            customer.Locale = ("en_GB");
            order.Customer = (customer);

            body.Order = (order);

            using (Client client = GetClient())
            {
                RiskAssessmentResponse riskAssessmentResponse = await client
                    .Merchant(GetMerchantId())
                    .Riskassessments()
                    .Bankaccounts(body);
                Assert.That(riskAssessmentResponse.Results, Is.Not.Empty);
            }
        }
    }
}
