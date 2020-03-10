using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Linq.Enumerable;
using Ingenico.Connect.Sdk.DefaultImpl;

namespace Ingenico.Connect.Sdk
{
    [TestFixture]
    public class MetaDataProviderTest
    {
        [TestCase]
        public void TestGetServerMetaDataHeadersNoAdditionalHeaders()
        {
            MetaDataProvider metaDataProvider = new MetaDataProvider("Ingenico");

            IEnumerable<RequestHeader> requestHeaders = metaDataProvider.ServerMetaDataHeaders;
            Assert.AreEqual(1, requestHeaders.Count());

            RequestHeader requestHeader = requestHeaders.First();
            AssertServerMetaInfo(metaDataProvider, requestHeader);
        }

        [TestCase]
        public void TestGetServerMetaDataHeadersWithAdditionalHeaders()
        {
            IList<RequestHeader> additionalHeaders = new List<RequestHeader>();
            additionalHeaders.Add(new RequestHeader("Header1", "Value1"));
            additionalHeaders.Add(new RequestHeader("Header2", "Value2"));
            additionalHeaders.Add(new RequestHeader("Header3", "Value3"));

            MetaDataProvider metaDataProvider = new MetaDataProviderBuilder("Ingenico") { AdditionalRequestHeaders = additionalHeaders }.Build();

            IEnumerable<RequestHeader> requestHeaders = metaDataProvider.ServerMetaDataHeaders;
            Assert.AreEqual(4, requestHeaders.Count());
            RequestHeader requestHeader = requestHeaders.First();
            AssertServerMetaInfo(metaDataProvider, requestHeader);

            IEnumerator<RequestHeader> enumerator = requestHeaders.GetEnumerator();
            enumerator.MoveNext();
            foreach (RequestHeader additionalHeader in additionalHeaders)
            {
                Assert.True(enumerator.MoveNext());
                requestHeader = enumerator.Current;
                Assert.AreEqual(requestHeader, additionalHeader);
            }
        }

        [TestCase]
        public void TestConstructorWithProhibitedHeaders()
        {
            foreach (string name in MetaDataProvider.ProhibitedHeaders)
            {
                ICollection<RequestHeader> headers = new List<RequestHeader>
                {
                    new RequestHeader("Header1", "Value1"),
                    new RequestHeader(name, "whatever"),
                    new RequestHeader("Header2", "Value2")
                };

                Assert.That(() => new MetaDataProviderBuilder("Ingenico") { AdditionalRequestHeaders = headers }.Build(), Throws.ArgumentException.With.Message.Contain(name));
            }
        }

        void AssertServerMetaInfo(MetaDataProvider metaDataProvider, RequestHeader requestHeader)
        {
            Assert.AreEqual(requestHeader.Name, "X-GCS-ServerMetaInfo");
            Assert.NotNull(requestHeader.Value);

            byte[] data = Convert.FromBase64String(requestHeader.Value);
            string serverMetaInfoJson = Encoding.UTF8.GetString(data);

            MetaDataProvider.ServerMetaInfo serverMetaInfo = DefaultMarshaller.Instance.Unmarshal<MetaDataProvider.ServerMetaInfo>(serverMetaInfoJson);
            Assert.AreEqual(metaDataProvider.SdkIdentifier, serverMetaInfo.SdkIdentifier);
            Assert.AreEqual("Ingenico", serverMetaInfo.SdkCreator);
            Assert.AreEqual(metaDataProvider.PlatformIdentifier, serverMetaInfo.PlatformIdentifier);
        }
    }
}
