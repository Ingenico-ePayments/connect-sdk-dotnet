using NUnit.Framework;
using Ingenico.Connect.Sdk.Domain.Product;
using System.Threading.Tasks;
using Ingenico.Connect.Sdk.Merchant.Products;

namespace Ingenico.Connect.Sdk.It
{
    public class PaymentProductsTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for products service.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            var lParams = new DirectoryParams();
            lParams.CountryCode = ("NL");
            lParams.CurrencyCode = ("EUR");

            using (Client client = GetClient())
            {
                Directory response = await client
                    .Merchant(GetMerchantId())
                    .Products()
                    .Directory(809, lParams);

                Assert.That(response.Entries, Is.Not.Empty);
            }
        }
    }
}
