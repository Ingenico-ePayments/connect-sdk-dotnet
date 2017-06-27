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
    public class UpdateTokenExample
    {
        public async void Example()
        {
#pragma warning disable 0168
            using (Client client = GetClient())
            {
                Address billingAddress = new Address();
                billingAddress.AdditionalInfo = "b";
                billingAddress.City = "Monument Valley";
                billingAddress.CountryCode = "US";
                billingAddress.HouseNumber = "13";
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

                CardWithoutCvv cardWithoutCvv = new CardWithoutCvv();
                cardWithoutCvv.CardNumber = "4567350000427977";
                cardWithoutCvv.CardholderName = "Wile E. Coyote";
                cardWithoutCvv.ExpiryDate = "0820";
                cardWithoutCvv.IssueNumber = "12";

                TokenCardData data = new TokenCardData();
                data.CardWithoutCvv = cardWithoutCvv;

                TokenCard card = new TokenCard();
                card.Customer = customer;
                card.Data = data;

                UpdateTokenRequest body = new UpdateTokenRequest();
                body.Card = card;
                body.PaymentProductId = 1;

                await client.Merchant("merchantId").Tokens().Update("tokenId", body);
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
