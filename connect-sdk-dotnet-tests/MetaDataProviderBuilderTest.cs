using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ingenico.Connect.Sdk
{
    [TestFixture]
    public class MetaDataProviderBuilderTest
    {
        [TestCase]
        public void TestWithAdditionalRequestHeader()
        {
            foreach (var a in Parameters)
            {
                CheckWithAdditionalRequestHeader(a.Item1, a.Item2);
            }
        }

        public static void CheckWithAdditionalRequestHeader(string additionalHeaderName, bool isAllowed)
        {
            RequestHeader additionalRequestHeader = new RequestHeader(additionalHeaderName, Guid.NewGuid().ToString());

            MetaDataProviderBuilder builder = new MetaDataProviderBuilder("Ingenico");
            if (isAllowed)
            {
                MetaDataProvider metaDataProvider = builder.WithAdditionalRequestHeader(additionalRequestHeader).Build();
                IEnumerable<RequestHeader> requestHeaders = metaDataProvider.ServerMetaDataHeaders;
                Assert.AreEqual(2, requestHeaders.Count());

                RequestHeader requestHeader = requestHeaders.First();
                Assert.AreEqual("X-GCS-ServerMetaInfo", requestHeader.Name);

                requestHeader = requestHeaders.Skip(1).First();
                Assert.AreEqual(requestHeader, additionalRequestHeader);
            }
            else {
                Assert.That((() => builder.WithAdditionalRequestHeader(additionalRequestHeader)), Throws.ArgumentException.With.Message.Contains(additionalHeaderName));
            }
        }

        public static IEnumerable<Tuple<string, bool>> Parameters
        {
            get
            {
                foreach (string prohibitedHeaders in MetaDataProvider.ProhibitedHeaders)
                {
                    yield return Tuple.Create(prohibitedHeaders, false);
                }
                yield return Tuple.Create("Dummy", true);
                yield return Tuple.Create("Accept", true);
                yield return Tuple.Create("If-None-Match", true);
                yield return Tuple.Create("If-Modified-Since", true);
            }
        }
    }
}
