using NUnit.Framework;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    [TestFixture]
    public class ConnectionTestTest : IntegrationTest
    {
        /// <summary>
        /// Smoke test for test connection.
        /// </summary>
        [TestCase]
        public async Task Test()
        {
            using (Client client = GetClient())
            {
                await client.Merchant(GetMerchantId()).Services().Testconnection();
            }
        }
    }
}
