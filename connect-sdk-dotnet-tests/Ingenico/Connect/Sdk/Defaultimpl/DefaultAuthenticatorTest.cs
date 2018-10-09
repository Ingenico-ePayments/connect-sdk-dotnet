using NUnit.Framework;
using System;
using System.Net.Http;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.DefaultImpl
{
    [TestFixture]
    public class DefaultAuthenticatorTest
    {
        [TestCase]
        public void TestToCanonicalizeHeaderValue()
        {
            DefaultAuthenticator authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "apiKeyId", "secretApiKey");
            Assert.AreEqual("aap noot", authenticator.ToCanonicalizeHeaderValue("aap\nnoot  "));
            Assert.AreEqual("aap noot", authenticator.ToCanonicalizeHeaderValue(" aap\r\n  noot"));
        }

        [TestCase]
        public void TestToCanonicalizeHeaderValue2()
        {
            DefaultAuthenticator authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "apiKeyId", "secretApiKey");
            var val1 = authenticator.ToCanonicalizeHeaderValue(" some value  \r\n \n with  some \r\n  spaces ");
            Assert.AreEqual("some value    with  some  spaces", val1);
        }

        [TestCase]
        public void TestToDataToSign()
        {
            DefaultAuthenticator authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "apiKeyId", "secretApiKey");
            IList<RequestHeader> httpHeaders = new List<RequestHeader>();
            httpHeaders.Add(new RequestHeader("X-GCS-ServerMetaInfo", "{\"platformIdentifier\":\"Windows 7/6.1 Java/1.7 (Oracle Corporation; Java HotSpot(TM) 64-Bit Server VM; 1.7.0_45)\",\"sdkIdentifier\":\"1.0\"}"));
            httpHeaders.Add(new RequestHeader("Content-Type", "application/json"));
            httpHeaders.Add(new RequestHeader("X-GCS-ClientMetaInfo", "{\"aap\",\"noot\"}"));
            httpHeaders.Add(new RequestHeader("User-Agent", "Apache-HttpClient/4.3.4 (java 1.5)"));
            httpHeaders.Add(new RequestHeader("Date", "Mon, 07 Jul 2014 12:12:40 GMT"));
            string dataToSign = authenticator.ToDataToSign(HttpMethod.Post, new Uri("http://localhost:8080/v1/9991/services%20bla/convert/amount?aap=noot&mies=geen%20noot"), httpHeaders);

            string expectedStart =
                "POST\napplication/json\n";
            string expectedEnd =
                "x-gcs-clientmetainfo:{\"aap\",\"noot\"}\nx-gcs-servermetainfo:{\"platformIdentifier\":\"Windows 7/6.1 Java/1.7 (Oracle Corporation; Java HotSpot(TM) 64-Bit Server VM; 1.7.0_45)\",\"sdkIdentifier\":\"1.0\"}\n/v1/9991/services%20bla/convert/amount?aap=noot&mies=geen noot\n";

            string actualStart = dataToSign.Substring(0, 22);
            string actualEnd = dataToSign.Substring(52, dataToSign.Length-52);

            Assert.AreEqual(expectedStart, actualStart);
            Assert.AreEqual(expectedEnd, actualEnd);
        }

        [TestCase]
        public void TestCreateAuthenticationSignature()
        {
            DefaultAuthenticator authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "apiKeyId", "secretApiKey");

            string dataToSign = "DELETE\napplication/json\nFri, 06 Jun 2014 13:39:43 GMT\nx-gcs-clientmetainfo:processed header value\nx-gcs-customerheader:processed header value\nx-gcs-servermetainfo:processed header value\n/v1/9991/tokens/123456789\n";

            string authenticationSignature = authenticator.SignData(dataToSign);

            Assert.AreEqual("VfnXpPBQQoHZivTcAg0JvOWkhnzlPnaCPKpTQn/uMJM=", authenticationSignature);
        }

        [TestCase]
        public void TestCreateAuthenticationSignature2()
        {
            DefaultAuthenticator authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "EC36A74A98D21", "6Kj5HT0MQKC6D8eb7W3lTg71kVKVDSt1");

            string dataToSign = "GET\n\nFri, 06 Jun 2014 13:39:43 GMT\n/v1/9991/tokens/123456789\n";

            string authenticationSignature = authenticator.SignData(dataToSign);

            Assert.AreEqual("9ond5EIN05dBXJGCLRK5om9pxHsyrh/12pZJ7bvmwNM=", authenticationSignature);
        }

        [TestCase]
        public void TestTotalMinimalExample()
        {
            var authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "5e45c937b9db33ae", "I42Zf4pVnRdroHfuHnRiJjJ2B6+22h0yQt/R3nZR8Xg=");
            IList<RequestHeader> httpHeaders = new List<RequestHeader>();
            httpHeaders.Add(new RequestHeader("User-Agent", "Apache-HttpClient/4.3.4 (java 1.5)"));
            httpHeaders.Add(new RequestHeader("Date", "Fri, 06 Jun 2014 13:39:43 GMT"));
            string signature = authenticator.CreateSimpleAuthenticationSignature(HttpMethod.Get, new Uri("http://world.api-ingenico.com:8080/v1/9991/tokens/123456789"), httpHeaders);
            Assert.AreEqual("GCS v1HMAC:5e45c937b9db33ae:J5LjfSBvrQNhu7gG0gvifZt+IWNDReGCmHmBmth6ueI=", signature);
        }

        [TestCase]
        public void TestTotalFullExample()
        {
            var authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "5e45c937b9db33ae", "I42Zf4pVnRdroHfuHnRiJjJ2B6+22h0yQt/R3nZR8Xg=");
            IList<RequestHeader> httpHeaders = new List<RequestHeader>();
            httpHeaders.Add(new RequestHeader("User-Agent", "Apache-HttpClient/4.3.4 (java 1.5)"));
            httpHeaders.Add(new RequestHeader("X-GCS-ServerMetaInfo", "processed header value"));
            httpHeaders.Add(new RequestHeader("X-GCS-ClientMetaInfo", "processed header value"));
            httpHeaders.Add(new RequestHeader("Content-Type", "application/json"));
            httpHeaders.Add(new RequestHeader("X-GCS-CustomerHeader", "processed header value"));
            httpHeaders.Add(new RequestHeader("Date", "Fri, 06 Jun 2014 13:39:43 GMT"));
            string signature = authenticator.CreateSimpleAuthenticationSignature(HttpMethod.Delete, new Uri("http://world.api-ingenico.com:8080/v1/9991/tokens/123456789"), httpHeaders);
            Assert.AreEqual("GCS v1HMAC:5e45c937b9db33ae:jGWLz3ouN4klE+SkqO5gO+KkbQNM06Rric7E3dcfmqw=", signature);
        }
    }
}
