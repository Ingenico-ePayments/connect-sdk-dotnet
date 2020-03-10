using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk
{
    [TestFixture]
    public class CommunicatorTest
    {
        readonly Uri baseUri = new Uri("https://api-sandbox.globalcollect.com");
        readonly Mock<Session> sessionMock = new Mock<Session>();

        [TestCase]
        public void TestToURIWithoutRequestParams()
        {
            sessionMock.SetupGet(x => x.ApiEndpoint).Returns(baseUri);
            Communicator communicator = 
                new Communicator(sessionMock.Object, DefaultImpl.DefaultMarshaller.Instance);
            Uri uri = communicator.ToAbsoluteURI("v1/merchant/20000/convertamount", new List<RequestParam>());
            Uri uri2 = communicator.ToAbsoluteURI("/v1/merchant/20000/convertamount", new List<RequestParam>());

            Assert.That(uri, Is.EqualTo(new Uri("https://api-sandbox.globalcollect.com/v1/merchant/20000/convertamount")));
            Assert.That(uri2, Is.EqualTo(new Uri("https://api-sandbox.globalcollect.com/v1/merchant/20000/convertamount")));
        }

        [TestCase]
        public void TestToURIWithRequestParams()
        {
            IList<RequestParam> list = new List<RequestParam>();
            list.Add(new RequestParam("amount", "123"));
            list.Add(new RequestParam("source", "USD"));
            list.Add(new RequestParam("target", "EUR"));
            list.Add(new RequestParam("dummy", "é&%="));
            sessionMock.SetupGet(x => x.ApiEndpoint).Returns(baseUri);
            var communicator = new Communicator(sessionMock.Object, DefaultImpl.DefaultMarshaller.Instance);
            Uri uri = communicator.ToAbsoluteURI("v1/merchant/20000/convertamount", list);
            Uri uri2 = communicator.ToAbsoluteURI("/v1/merchant/20000/convertamount", list);

            Assert.AreEqual(new Uri("https://api-sandbox.globalcollect.com/v1/merchant/20000/convertamount?amount=123&source=USD&target=EUR&dummy=%C3%A9%26%25%3D"), uri);
            Assert.AreEqual(new Uri("https://api-sandbox.globalcollect.com/v1/merchant/20000/convertamount?amount=123&source=USD&target=EUR&dummy=%C3%A9%26%25%3D"), uri2);
        }
    }
}
