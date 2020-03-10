using NUnit.Framework;
using System.Linq;
using Ingenico.Connect.Sdk.Merchant.Services;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    public class ConnectionPoolingTest : IntegrationTest
    {
        [TestCase(10, 10)]
        [TestCase(10, 5)]
        [TestCase(10, 1)]
        public async Task TestconnectionPooling(int requestCount, int maxConnections)
        {
            var configuration = GetCommunicatorConfiguration().WithMaxConnections(maxConnections);
            using (var communicator = Factory.CreateCommunicator(configuration))
            {
                await ActuallyTestConnectionPooling(communicator, requestCount);
            }
        }

        async Task ActuallyTestConnectionPooling(Communicator communicator, int requestCount)
        {
            await Task.WhenAll(Enumerable.Range(0, requestCount)
                               .Select((requestNum) =>
                                          Factory.CreateClient(communicator)
                                          .WithClientMetaInfo("")
                                          .Merchant(GetMerchantId())
                                          .Services()
                                          .ConvertAmount(
                                              new ConvertAmountParams
                                              {
                                                  Source = "USD",
                                                  Target = "EUR",
                                                  Amount = 100L * (requestNum + 1)
                                              }
                                         )
                                     ).ToList()
                              );
        }
    }
}
