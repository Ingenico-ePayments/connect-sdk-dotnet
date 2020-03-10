using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Ingenico.Connect.Sdk.DefaultImpl;
using Ingenico.Connect.Sdk.Util;

namespace Ingenico.Connect.Sdk
{
    [TestFixture]
    public class ClientTest
    {
        [TestCase]
        public void TestWithClientMetaInfo()
        {
            Client client1 = Factory.CreateClient(FactoryTest.DICT, FactoryTest.API_KEY_ID, FactoryTest.SECRET_API_KEY);
            AssertNoClientHeaders(client1);

            Client client2 = client1.WithClientMetaInfo(null);
            Assert.AreSame(client1, client2);

            string clientMetaInfo = DefaultMarshaller.Instance.Marshal(new Dictionary<string, string> { { "test", "test" } });
            Client client3 = client1.WithClientMetaInfo(clientMetaInfo);

            Assert.AreNotSame(client1, client3);
            AssertClientHeaders(client3, clientMetaInfo);

            Client client4 = client3.WithClientMetaInfo(clientMetaInfo);
            Assert.AreSame(client3, client4);

            Client client5 = client3.WithClientMetaInfo(null);
            Assert.AreNotSame(client3, client5);
            AssertNoClientHeaders(client5);

            // nothing can be said about client1 and client5 being the same or not
        }

        void AssertClientHeaders(Client client, string clientMetaInfo)
        {
            IEnumerable<RequestHeader> headers = GetHeaders(client);

            string headerValue = clientMetaInfo.ToBase64String();

            Assert.NotNull(headers.FirstOrDefault(v => v.Equals(new RequestHeader("X-GCS-ClientMetaInfo", headerValue))));
        }

        void AssertNoClientHeaders(Client client)
        {
            IEnumerable<RequestHeader> headers = GetHeaders(client);
            Assert.Null(headers);
        }

        private IEnumerable<RequestHeader> GetHeaders(Client client)
        {
            // ApiResource.ClientHeaders is protected, so this test class has no access to it; use reflection to get it
            return client.GetPrivateProperty<IEnumerable<RequestHeader>>("ClientHeaders");
        }

        [TestCase]
        public void TestCloseIdleConnectionsNotPooled()
        {
            // No-op because done automatically by system.
        }

        [TestCase]
        public void TestCloseIdleConnectionsPooled()
        {
            // No-op because done automatically by system.
        }

        [TestCase]
        public void TestCloseExpiredConnectionsNotPooled()
        {
            // No-op because done automatically by system.
        }

        [TestCase]
        public void TestCloseExpiredConnectionsPooled()
        {
            // No-op because done automatically by system.
        }
    }
}
