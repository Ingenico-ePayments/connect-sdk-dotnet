using NUnit.Framework;
using Ingenico.Connect.Sdk.Domain.Token;
using Ingenico.Connect.Sdk.Domain.Token.Definitions;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Merchant.Tokens;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    public class TokenTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for token calls.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            CreateTokenRequest createTokenRequest = new CreateTokenRequest();
            createTokenRequest.PaymentProductId = (1);
            TokenCard card = new TokenCard();
            createTokenRequest.Card = (card);
            CustomerToken customer = new CustomerToken();
            card.Customer = (customer);
            Address billingAddress = new Address();
            customer.BillingAddress = (billingAddress);
            billingAddress.CountryCode = ("NL");
            TokenCardData mandate = new TokenCardData();
            card.Data = (mandate);
            CardWithoutCvv cardWithoutCvv = new CardWithoutCvv();
            mandate.CardWithoutCvv = (cardWithoutCvv);
            cardWithoutCvv.CardholderName = ("Jan");
            cardWithoutCvv.IssueNumber = ("12");
            cardWithoutCvv.CardNumber = ("4567350000427977");
            cardWithoutCvv.ExpiryDate = ("0820");

            using (Client client = GetClient())
            {
                CreateTokenResponse createTokenResponse = await client
                    .Merchant(GetMerchantId())
                    .Tokens()
                    .Create(createTokenRequest);

                Assert.NotNull(createTokenResponse.Token);

                DeleteTokenParams deleteTokenRequest = new DeleteTokenParams();

                await client
                    .Merchant(GetMerchantId())
                    .Tokens()
                    .Delete(createTokenResponse.Token, deleteTokenRequest);
            }
        }
    }
}
