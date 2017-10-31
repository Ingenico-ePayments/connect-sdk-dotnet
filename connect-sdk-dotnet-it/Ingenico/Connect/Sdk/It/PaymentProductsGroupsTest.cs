using NUnit.Framework;
using Ingenico.Connect.Sdk.Merchant.Productgroups;
using Ingenico.Connect.Sdk.Domain.Product;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    public class PaymentProductsGroupsTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for product groups service.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            var lParams = new GetProductgroupParams();
            lParams.CountryCode = ("NL");
            lParams.CurrencyCode = ("EUR");

            using (Client client = GetClient())
            {
                PaymentProductGroupResponse response = await client
                    .Merchant(GetMerchantId())
                    .Productgroups()
                    .Get("cards", lParams);

                Assert.AreEqual("cards", response.Id);
            }
        }
    }
}
