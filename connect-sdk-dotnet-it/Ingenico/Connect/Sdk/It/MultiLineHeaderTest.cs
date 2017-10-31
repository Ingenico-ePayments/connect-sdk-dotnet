using NUnit.Framework;
using Ingenico.Connect.Sdk.Merchant.Products;
using Ingenico.Connect.Sdk.Domain.Product;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    public class MultiLineHeaderTest : IntegrationTest
    {
        [TestCase]
        public async Task Test()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();

            string multiLineHeader = " some value  \r\n \n with  some \r\n  spaces ";
            MetaDataProvider metaDataProvider = new MetaDataProviderBuilder("Ingenico")
                    .WithAdditionalRequestHeader(new RequestHeader("X-GCS-MultiLineHeader", multiLineHeader))
                    .Build();

            DirectoryParams lParams = new DirectoryParams();
            lParams.CountryCode = ("NL");
            lParams.CurrencyCode = ("EUR");

            Session session = Factory.CreateSessionBuilder(configuration)
                    .WithMetaDataProvider(metaDataProvider)
                    .Build();
            using (Client client = Factory.CreateClient(session))
            {
                Directory response = await client
                    .Merchant(GetMerchantId())
                    .Products()
                    .Directory(809, lParams);

                Assert.That(response.Entries, Is.Not.Empty);

            }
        }

        [TestCase]
        public async Task SimpleTest()
        {
            CommunicatorConfiguration configuration = GetCommunicatorConfiguration();

            string multiLineHeader = "some\nvalue";
            MetaDataProvider metaDataProvider = new MetaDataProviderBuilder("Ingenico")
                    .WithAdditionalRequestHeader(new RequestHeader("X-GCS-MultiLineHeader", multiLineHeader))
                    .Build();

            Session session = Factory.CreateSessionBuilder(configuration)
                    .WithMetaDataProvider(metaDataProvider)
                    .Build();
            using (Client client = Factory.CreateClient(session))
            {
                await client
                    .Merchant(GetMerchantId())
                    .Services()
                    .Testconnection();
            }
        }
    }
}
