using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;
using Ingenico.Connect.Sdk.DefaultImpl;
using System.Net;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using Ingenico.Connect.Sdk.Domain.Definitions;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    [TestFixture]
    public class PaymentsClientTest
    {
        const string pendingApprovalJson = @"{
    ""creationOutput"": {
        ""additionalReference"": ""00000200002014254946"",
        ""externalReference"": ""000002000020142549460000100001""
    },
    ""payment"": {
        ""id"": ""000002000020142549460000100001"",
        ""paymentOutput"": {
            ""amountOfMoney"": {
                ""amount"": 2345,
                ""currencyCode"": ""CAD""
            },
            ""references"": {
                ""paymentReference"": ""0""
            },
            ""paymentMethod"": ""card"",
            ""cardPaymentMethodSpecificOutput"": {
                ""paymentProductId"": 1,
                ""authorisationCode"": ""OK1131"",
                ""card"": {
                    ""cardNumber"": ""************9176"",
                    ""expiryDate"": ""1220""
                },
                ""fraudResults"": {
                    ""fraudServiceResult"": ""error"",
                    ""avsResult"": ""X"",
                    ""cvvResult"": ""M""
                }
            }
        },
        ""status"": ""PENDING_APPROVAL"",
        ""statusOutput"": {
            ""isCancellable"": true,
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20150331120036"",
            ""isAuthorized"": true
        }
    }
}";
        const string duplicateRequestJson = @"{
   ""errorId"" : ""75b0f13a-04a5-41b3-83b8-b295ddb23439-000013c6"",
   ""errors"" : [ {
      ""code"" : ""1409"",
      ""message"" : ""DUPLICATE REQUEST IN PROGRESS"",
      ""httpStatusCode"" : 409
   } ]
}";
        const string invalidAuthorizationJson = @"{
    ""errorId"": ""fbd8d914-c889-45d3-a396-9e0d9ff9db88-0000006f"",
    ""errors"": [
        {
            ""code"": ""9002"",
            ""message"": ""MISSING_OR_INVALID_AUTHORIZATION""
        }
    ]
}";
        const string invalidRequestJson = @"{
    ""errorId"": ""2c164323-20d3-4e9e-8578-dc562cd7506c-00000058"",
    ""errors"": [
        {
            ""code"": ""21000120"",
            ""requestId"": ""2001803"",
            ""propertyName"": ""cardPaymentMethodSpecificInput.card.expiryDate"",
            ""message"": ""paymentMethodSpecificInput.card.expiryDate (1210) IS IN THE PAST OR NOT IN CORRECT MMYY FORMAT""
        }
    ]
}";
        const string rejectedJson = @"{
    ""errorId"": ""2c164323-20d3-4e9e-8578-dc562cd7506c-0000003c"",
    ""errors"": [
        {
            ""code"": ""21000020"",
            ""requestId"": ""2001798"",
            ""message"": ""VALUE **************** OF FIELD CREDITCARDNUMBER DID NOT PASS THE LUHNCHECK""
        }
    ],
    ""paymentResult"": {
        ""creationOutput"": {
            ""additionalReference"": ""00000200002014254436"",
            ""externalReference"": ""000002000020142544360000100001""
        },
        ""payment"": {
            ""id"": ""000002000020142544360000100001"",
            ""paymentOutput"": {
                ""amountOfMoney"": {
                    ""amount"": 2345,
                    ""currencyCode"": ""CAD""
                },
                ""references"": {
                    ""paymentReference"": ""0""
                },
                ""paymentMethod"": ""card"",
                ""cardPaymentMethodSpecificOutput"": {
                    ""paymentProductId"": 1
                }
            },
            ""status"": ""REJECTED"",
            ""statusOutput"": {
                ""errors"": [
                    {
                        ""code"": ""21000020"",
                        ""requestId"": ""2001798"",
                        ""message"": ""VALUE **************** OF FIELD CREDITCARDNUMBER DID NOT PASS THE LUHNCHECK""
                    }
                ],
                ""isCancellable"": false,
                ""statusCode"": 100,
                ""statusCodeChangeDateTime"": ""20150330173151"",
                ""isAuthorized"": false
            }
        }
    }
}";
        const string methodNotAllowedHtml = @"Method Not Allowed";
        const string notFoundHtml = @"Not Found";

        // [SetUp]
        public PaymentsClientTest()
        {

        }

        public static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// Tests that a non-failure response will not throw an exception.
        /// </summary>
        [TestCase]
        public async Task TestCreateSuccess()
        {
            var connectionMock = new Mock<IConnection>();
            // new Response((HttpStatusCode)201, pendingApprovalJson, null
            var jsonStream = GenerateStreamFromString(pendingApprovalJson);
            connectionMock.Setup(arg
                    => arg.Post(Moq.It.IsAny<Uri>(), Moq.It.IsAny<IEnumerable<IRequestHeader>>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)201, jsonStream, new List<IResponseHeader>())));

            Uri apiEndpoint = new Uri("http://localhost");
            var session = new Session(apiEndpoint, connectionMock.Object, new DefaultAuthenticator(AuthorizationType.V1HMAC, "test", "test"), new MetaDataProvider("Ingenico"));

            Client client = Factory.CreateClient(session);

            CreatePaymentRequest body = CreateRequest();

            CreatePaymentResponse response = await client.Merchant("merchantId").Payments().Create(body);
            Assert.AreEqual("000002000020142549460000100001", response.Payment.Id);
            Assert.AreEqual("PENDING_APPROVAL", response.Payment.Status);
        }

        /// <summary>
        /// Tests that a failure response with a payment result will throw a <see cref="DeclinedPaymentException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateRejected()
        {
            var connectionMock = new Mock<IConnection>();

            connectionMock.Setup(arg
                    => arg.Post(Moq.It.IsAny<Uri>(), Moq.It.IsAny<IEnumerable<IRequestHeader>>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                        .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)400, GenerateStreamFromString(rejectedJson), new List<IResponseHeader>())));

            Uri apiEndpoint = new Uri("http://localhost");
            var session = new Session(apiEndpoint, connectionMock.Object, new DefaultAuthenticator(AuthorizationType.V1HMAC, "test", "test"), new MetaDataProvider("Ingenico"));

            Client client = Factory.CreateClient(session);

            CreatePaymentRequest body = CreateRequest();

            try
            {
                await client.Merchant("merchantId").Payments().Create(body);
                Assert.Fail("DeclinedPaymentException expected");
            }
            catch (DeclinedPaymentException e)
            {
                Assert.That(e.ToString(), Does.Contain("payment '000002000020142544360000100001'"));
                Assert.That(e.ToString(), Does.Contain("status 'REJECTED'"));
                Assert.That(e.ToString(), Does.Contain(rejectedJson));
                Assert.That(e.CreatePaymentResult, Is.Not.Null);
                Assert.That(e.CreatePaymentResult.Payment.Id, Is.EqualTo("000002000020142544360000100001"));
                Assert.That(e.CreatePaymentResult.Payment.Status, Is.EqualTo("REJECTED"));
            }
        }

        /// <summary>
        /// Tests that a 400 failure response without a payment result will throw a <see cref="ValidationException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateInvalidRequest()
        {
            var connectionMock = new Mock<IConnection>();

            connectionMock.Setup(arg
                    => arg.Post(Moq.It.IsAny<Uri>(), Moq.It.IsAny<IEnumerable<IRequestHeader>>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)400, GenerateStreamFromString(invalidRequestJson), new List<IResponseHeader>())));


            Uri apiEndpoint = new Uri("http://localhost");
            var session = new Session(apiEndpoint, connectionMock.Object, new DefaultAuthenticator(AuthorizationType.V1HMAC, "test", "test"), new MetaDataProvider("Ingenico"));

            Client client = Factory.CreateClient(session);

            CreatePaymentRequest body = CreateRequest();

            try
            {
                await client.Merchant("merchantId").Payments().Create(body);
                Assert.Fail("ValidationException expected");
            }
            catch (ValidationException e)
            {
                Assert.That(e.ToString(), Does.Contain(invalidRequestJson));
            }
        }

        /// <summary>
        /// Tests that a 401 failure response without a payment result will throw a <see cref="ApiException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateInvalidAuthorization()
        {
            var connectionMock = new Mock<IConnection>();

            connectionMock.Setup(arg
                    => arg.Post(Moq.It.IsAny<Uri>(), Moq.It.IsAny<IEnumerable<IRequestHeader>>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)401, GenerateStreamFromString(invalidAuthorizationJson), new List<IResponseHeader>())));

            Uri apiEndpoint = new Uri("http://localhost");
            var session = new Session(apiEndpoint, connectionMock.Object, new DefaultAuthenticator(AuthorizationType.V1HMAC, "test", "test"), new MetaDataProvider("Ingenico"));

            Client client = Factory.CreateClient(session);

            CreatePaymentRequest body = CreateRequest();

            try
            {
                await client.Merchant("merchantId").Payments().Create(body);
                Assert.Fail("Api exception expected");
            }
            catch (ApiException e)
            {
                Assert.That(e.ToString(), Does.Contain(invalidAuthorizationJson));
            }
        }

        /// <summary>
        /// Tests that a 409 failure response with a duplicate request code but without an idempotence key will throw a
        /// <see cref="ReferenceException"/> .
        /// </summary>
        [TestCase]
        public async Task TestCreateReferenceError()
        {
            var connectionMock = new Mock<IConnection>();

            connectionMock.Setup(arg
                    => arg.Post(Moq.It.IsAny<Uri>(), Moq.It.IsAny<IEnumerable<IRequestHeader>>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)409, GenerateStreamFromString(duplicateRequestJson), new List<IResponseHeader>())));

            Uri apiEndpoint = new Uri("http://localhost");
            var session = new Session(apiEndpoint, connectionMock.Object, new DefaultAuthenticator(AuthorizationType.V1HMAC, "test", "test"), new MetaDataProvider("Ingenico"));

            Client client = Factory.CreateClient(session);

            CreatePaymentRequest body = CreateRequest();

            try
            {
                await client.Merchant("merchantId").Payments().Create(body);
                Assert.Fail("Reference exception expected");
            }
            catch (ReferenceException e)
            {
                Assert.That(e.ToString(), Does.Contain(duplicateRequestJson));
            }
        }

        /// <summary>
        /// Tests that a 409 failure response with a duplicate request code and an idempotence key will throw an <see cref="IdempotenceException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateIdempotenceError()
        {
            string responseBody = duplicateRequestJson;
            HttpStatusCode code = (HttpStatusCode)409;
            var idempotenceKey = "key";
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(arg
                    => arg.Post(Moq.It.IsAny<Uri>(), Moq.It.IsAny<IEnumerable<IRequestHeader>>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)code, GenerateStreamFromString(responseBody), null)));

            Uri apiEndpoint = new Uri("http://localhost");
            var session = new Session(apiEndpoint, connectionMock.Object, new DefaultAuthenticator(AuthorizationType.V1HMAC, "test", "test"), new MetaDataProvider("Ingenico"));

            CallContext context = new CallContext().WithIdempotenceKey(idempotenceKey);

            Client client = Factory.CreateClient(session);

            CreatePaymentRequest body = CreateRequest();

            try
            {
                await client.Merchant("merchantId").Payments().Create(body, context);
                Assert.Fail("Idempotence exception expected");
            }
            catch (IdempotenceException e)
            {
                Assert.That(e.ToString(), Does.Contain(responseBody));
                Assert.That(e.IdempotenceKey, Is.EqualTo(context.IdempotenceKey));
            }
        }

        /// <summary>
        /// Tests that a 404 response with a non-JSON response will throw a <see cref="NotFoundException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateNotFound()
        {
            string responseBody = notFoundHtml;
            HttpStatusCode code = (HttpStatusCode)404;
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(arg
                    => arg.Post(Moq.It.IsAny<Uri>(), Moq.It.IsAny<IEnumerable<IRequestHeader>>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)code, GenerateStreamFromString(responseBody), new List<IResponseHeader> { new ResponseHeader("content-type", "text/html") })));

            Uri apiEndpoint = new Uri("http://localhost");
            var session = new Session(apiEndpoint, connectionMock.Object, new DefaultAuthenticator(AuthorizationType.V1HMAC, "test", "test"), new MetaDataProvider("Ingenico"));

            Client client = Factory.CreateClient(session);

            CreatePaymentRequest body = CreateRequest();

            try
            {
                await client.Merchant("merchantId").Payments().Create(body);
                Assert.Fail("NotFoundException exception expected");
            }
            catch (NotFoundException e)
            {
                Assert.That(e.InnerException, Is.Not.Null);
                Assert.That(e.InnerException, Is.TypeOf(typeof(ResponseException)));
                Assert.That(e.InnerException.ToString(), Does.Contain(responseBody));
            }
        }

        /// <summary>
        /// Tests that a 405 response with a non-JSON response will throw a <see cref="CommunicationException"/>.
        /// </summary>
        [TestCase]
        public async Task TestCreateMethodNotAllowed()
        {
            string responseBody = methodNotAllowedHtml;
            HttpStatusCode code = (HttpStatusCode)405;
            var connectionMock = new Mock<IConnection>();
            connectionMock.Setup(arg
                    => arg.Post(Moq.It.IsAny<Uri>(), Moq.It.IsAny<IEnumerable<IRequestHeader>>(), Moq.It.IsAny<string>(), Moq.It.IsAny<Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse>>()))
                .Returns((Uri a, IEnumerable<IRequestHeader> b, string c, Func<HttpStatusCode, Stream, IEnumerable<IResponseHeader>, CreatePaymentResponse> d)
                    => Task.FromResult(d((HttpStatusCode)code, GenerateStreamFromString(responseBody), new List<IResponseHeader> { new ResponseHeader("content-type", "text/html") })));

            Uri apiEndpoint = new Uri("http://localhost");
            var session = new Session(apiEndpoint, connectionMock.Object, new DefaultAuthenticator(AuthorizationType.V1HMAC, "test", "test"), new MetaDataProvider("Ingenico"));

            Client client = Factory.CreateClient(session);

            CreatePaymentRequest body = CreateRequest();

            try
            {
                await client.Merchant("merchantId").Payments().Create(body);
                Assert.Fail("ResponseException exception expected");
            }
            catch (CommunicationException e)
            {
                Assert.That(e.InnerException, Is.Not.Null);
                Assert.That(e.InnerException, Is.TypeOf(typeof(ResponseException)));
                Assert.That(e.InnerException.ToString(), Does.Contain(responseBody));
            }
        }


        CreatePaymentRequest CreateRequest()
        {

            CreatePaymentRequest body = new CreatePaymentRequest();

            Order order = new Order();

            AmountOfMoney amountOfMoney = new AmountOfMoney();
            amountOfMoney.Amount = 2345L;
            amountOfMoney.CurrencyCode = "CAD";
            order.AmountOfMoney = amountOfMoney;

            Customer customer = new Customer();

            Address billingAddress = new Address();
            billingAddress.CountryCode = "CA";
            customer.BillingAddress = (billingAddress);

            order.Customer = customer;

            CardPaymentMethodSpecificInput cardPaymentMethodSpecificInput = new CardPaymentMethodSpecificInput();
            cardPaymentMethodSpecificInput.PaymentProductId = 1;

            Card card = new Card();
            card.Cvv = "123";
            card.CardNumber = "4567350000427977";
            card.ExpiryDate = "1220";
            cardPaymentMethodSpecificInput.Card = card;

            body.CardPaymentMethodSpecificInput = cardPaymentMethodSpecificInput;

            return body;
        }
    }
}
