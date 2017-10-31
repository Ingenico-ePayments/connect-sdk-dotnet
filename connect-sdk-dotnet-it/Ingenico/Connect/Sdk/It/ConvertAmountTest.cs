using NUnit.Framework;
using Ingenico.Connect.Sdk.Merchant.Services;
using Ingenico.Connect.Sdk.Domain.Services;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    [TestFixture]
    public class ConvertAmountTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for convert amount service.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            ConvertAmountParams request = new ConvertAmountParams();
            request.Amount = (123L);
            request.Source = ("USD");
            request.Target = ("EUR");

            using (Client client = GetClient())
            {
                ConvertAmount response = await client
                    .Merchant(GetMerchantId())
                    .Services()
                    .ConvertAmount(request);

                Assert.NotNull(response.ConvertedAmount);
            }
        }
    }
}
