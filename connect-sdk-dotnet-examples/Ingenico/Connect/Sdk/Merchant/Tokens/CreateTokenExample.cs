/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Token;
using Ingenico.Connect.Sdk.Domain.Token.Definitions;

namespace Ingenico.Connect.Sdk.Merchant.Tokens
{
    public class CreateTokenExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                Address billingAddress = new Address();
                billingAddress.AdditionalInfo = "Suite II";
                billingAddress.City = "Monument Valley";
                billingAddress.CountryCode = "US";
                billingAddress.HouseNumber = "1";
                billingAddress.State = "Utah";
                billingAddress.Street = "Desertroad";
                billingAddress.Zip = "84536";

                CompanyInformation companyInformation = new CompanyInformation();
                companyInformation.Name = "Acme Labs";

                PersonalNameToken name = new PersonalNameToken();
                name.FirstName = "Wile";
                name.Surname = "Coyote";
                name.SurnamePrefix = "E.";

                PersonalInformationToken personalInformation = new PersonalInformationToken();
                personalInformation.Name = name;

                CustomerToken customer = new CustomerToken();
                customer.BillingAddress = billingAddress;
                customer.CompanyInformation = companyInformation;
                customer.MerchantCustomerId = "1234";
                customer.PersonalInformation = personalInformation;

                BankAccountBban bankAccountBban = new BankAccountBban();
                bankAccountBban.AccountNumber = "000000123456";
                bankAccountBban.BankCode = "05428";
                bankAccountBban.BranchCode = "11101";
                bankAccountBban.CheckDigit = "X";
                bankAccountBban.CountryCode = "IT";

                TokenNonSepaDirectDebitPaymentProduct705SpecificData paymentProduct705SpecificData = new TokenNonSepaDirectDebitPaymentProduct705SpecificData();
                paymentProduct705SpecificData.AuthorisationId = "123456";
                paymentProduct705SpecificData.BankAccountBban = bankAccountBban;

                MandateNonSepaDirectDebit mandate = new MandateNonSepaDirectDebit();
                mandate.PaymentProduct705SpecificData = paymentProduct705SpecificData;

                TokenNonSepaDirectDebit nonSepaDirectDebit = new TokenNonSepaDirectDebit();
                nonSepaDirectDebit.Customer = customer;
                nonSepaDirectDebit.Mandate = mandate;

                CreateTokenRequest body = new CreateTokenRequest();
                body.NonSepaDirectDebit = nonSepaDirectDebit;
                body.PaymentProductId = 705;

                CreateTokenResponse response = await client.Merchant("merchantId").Tokens().Create(body);
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
