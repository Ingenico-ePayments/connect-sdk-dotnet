using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using Ingenico.Connect.Sdk.Merchant.Productgroups;
using Ingenico.Connect.Sdk.Domain.Sessions;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.It
{
    public class CreateSessionTest : IntegrationTest
    {
        /**
         * Smoke Test for products service.
         */
        [TestCase]
        public async Task Test()
        {
            var lParams = new SessionRequest();

            using (Client client = GetClient())
            {
                var l = Ingenico.Connect.Sdk.Logging.SystemConsoleCommunicatorLogger.Instance;
                var response = await client
                    .Merchant(GetMerchantId())
                    .Sessions()
                    .Create(lParams);
            }
        }
    }
}
