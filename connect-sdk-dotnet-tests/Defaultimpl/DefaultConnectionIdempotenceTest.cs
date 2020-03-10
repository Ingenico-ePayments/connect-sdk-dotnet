using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using MockHttpServer;
using NUnit.Framework;

namespace Ingenico.Connect.Sdk.DefaultImpl
{
    [TestFixture]
    public class DefaultConnectionIdempotenceTest
    {
        const int Port = 5357;

        static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        
        const string idempotenceSucessJson = @"{
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
        
        const string idempotenceRejectedJson = @"{
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
        
        const string idempotenceDepulicateFailureJson = @"{
   ""errorId"" : ""75b0f13a-04a5-41b3-83b8-b295ddb23439-000013c6"",
   ""errors"" : [ {
      ""code"" : ""1409"",
      ""message"" : ""DUPLICATE REQUEST IN PROGRESS"",
      ""httpStatusCode"" : 409
   } ]
}";

        Client CreateClient()
        {
            IConnection connection = new DefaultConnection(TimeSpan.FromMilliseconds(500000000), 500);
            IAuthenticator authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "apiKey", "secret");
            MetaDataProvider metaDataProvider = new MetaDataProvider("Ingenico");
            var uriBuilder = new UriBuilder("http", "localhost");
            uriBuilder.Port = Port;
            Session session = new Session(uriBuilder.Uri, connection, authenticator, metaDataProvider);
            Communicator communicator = Factory.CreateCommunicator(session);
            Client client = Factory.CreateClient(communicator);
            return client;
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
            customer.BillingAddress = billingAddress;

            order.Customer = customer;

            CardPaymentMethodSpecificInput cardPaymentMethodSpecificInput = new CardPaymentMethodSpecificInput();
            cardPaymentMethodSpecificInput.PaymentProductId = 1;

            Card card = new Card();
            card.Cvv = ("123");
            card.CardNumber = ("4567350000427977");
            card.ExpiryDate = ("1220");
            cardPaymentMethodSpecificInput.Card = (card);

            body.CardPaymentMethodSpecificInput = (cardPaymentMethodSpecificInput);

            return body;
        }

        [TestCase]
        public async Task TestIdempotenceFirstRequest()
        {
            string body = idempotenceSucessJson;
            string idempotenceKey = Guid.NewGuid().ToString();

            IDictionary<string, string> responseHeaders = new Dictionary<string, string>(1);
            responseHeaders.Add("Location", "http://localhost/v1/20000/payments/000002000020142549460000100001");

            IDictionary<string, string> requestHeaders = new Dictionary<string, string>();

            CallContext context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (MockServer host = new MockServer(Port, "/v1/20000/payments", (request, response, arg3) =>
                   {
                       RecordRequest((HttpStatusCode)201, request, requestHeaders, response, responseHeaders);
                       return body;
                   }))
            using (Client client = CreateClient())
            {
                CreatePaymentRequest request = CreateRequest();

                CreatePaymentResponse response = await client.Merchant("20000").Payments().Create(request, context);

                Assert.NotNull(response);
                Assert.NotNull(response.Payment);
                Assert.NotNull(response.Payment.Id);
            }
            Assert.AreEqual(idempotenceKey, requestHeaders[("X-GCS-Idempotence-Key")]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }

        [TestCase]
        public async Task TestIdempotenceSecondRequest()
        {
            string body = idempotenceSucessJson;
            string idempotenceKey = Guid.NewGuid().ToString();
            double idempotenceRequestTimestamp = (DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
            IDictionary<string, string> responseHeaders = new Dictionary<string, string>(1);
            responseHeaders.Add("Location", "http://localhost/v1/20000/payments/000002000020142549460000100001");
            responseHeaders.Add("X-GCS-Idempotence-Request-Timestamp", idempotenceRequestTimestamp.ToString());
            IDictionary<string, string> requestHeaders = new Dictionary<string, string>();

            CallContext context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (MockServer host = new MockServer(Port, "/v1/20000/payments", (request, response, arg3) =>
            {
                RecordRequest((HttpStatusCode)201, request, requestHeaders, response, responseHeaders);
                return body;
            }))
            using (Client client = CreateClient())
            {
                CreatePaymentRequest request = CreateRequest();

                CreatePaymentResponse response = await client.Merchant("20000").Payments().Create(request, context);

                Assert.NotNull(response);
                Assert.NotNull(response.Payment);
                Assert.NotNull(response.Payment.Id);
            }
            Assert.AreEqual(idempotenceKey, requestHeaders[("X-GCS-Idempotence-Key")]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }

        static void RecordRequest(HttpStatusCode statusCode, HttpListenerRequest request, IDictionary<string, string> requestHeaders, HttpListenerResponse response, IDictionary<string, string> responseHeaders)
        {
            foreach (string name in request.Headers)
            {
                requestHeaders.Add(name, request.Headers[name]);
            }
            response.StatusCode = (int)statusCode;
            response.ContentType = "application/json";
        }

        [TestCase]
        public async Task TestIdempotenceFirstFailure()
        {
            string body = idempotenceRejectedJson;
            string idempotenceKey = Guid.NewGuid().ToString();
            double idempotenceRequestTimestamp = (DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
            IDictionary<string, string> responseHeaders = new Dictionary<string, string>(1);
            responseHeaders.Add("Location", "http://localhost/v1/20000/payments/000002000020142549460000100001");
            responseHeaders.Add("X-GCS-Idempotence-Request-Timestamp", idempotenceRequestTimestamp.ToString());
            IDictionary<string, string> requestHeaders = new Dictionary<string, string>();

            CallContext context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (MockServer host = new MockServer(Port, "/v1/20000/payments", ((request, response, arg3) =>
            {
                RecordRequest(HttpStatusCode.PaymentRequired, request, requestHeaders, response, responseHeaders);
                response.StatusCode = 402;
                return body;
            })))
            using (Client client = CreateClient())
            {
                try
                {
                    CreatePaymentRequest request = CreateRequest();

                    await client.Merchant("20000").Payments().Create(request, context);

                    Assert.True(false, "Expected DeclinedPaymentException");
                }
                catch (DeclinedPaymentException e)
                {
                    Assert.AreEqual(HttpStatusCode.PaymentRequired, e.StatusCode);
                    Assert.AreEqual(body, e.ResponseBody);
                }
            }
            Assert.AreEqual(idempotenceKey, requestHeaders[("X-GCS-Idempotence-Key")]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }

        [TestCase]
        public async Task TestIdempotenceSecondFailure()
        {
            string body = idempotenceRejectedJson;
            string idempotenceKey = Guid.NewGuid().ToString();
            IDictionary<string, string> responseHeaders = new Dictionary<string, string>(1);
            responseHeaders.Add("Location", "http://localhost/v1/20000/payments/000002000020142549460000100001");
            IDictionary<string, string> requestHeaders = new Dictionary<string, string>();

            CallContext context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (MockServer host = new MockServer(Port, "/v1/20000/payments", ((request, response, arg3) =>
            {
                RecordRequest(HttpStatusCode.PaymentRequired, request, requestHeaders, response, responseHeaders);
                response.StatusCode = 402;
                return body;
            })))
            using (Client client = CreateClient())
            {
                try
                {
                    CreatePaymentRequest request = CreateRequest();

                    await client.Merchant("20000").Payments().Create(request, context);

                    Assert.True(false, "Expected DeclinedPaymentException");
                }
                catch (DeclinedPaymentException e)
                {
                    Assert.AreEqual(HttpStatusCode.PaymentRequired, e.StatusCode);
                    Assert.AreEqual(body, e.ResponseBody);
                }
            }
            Assert.AreEqual(idempotenceKey, requestHeaders[("X-GCS-Idempotence-Key")]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }

        [TestCase]
        public async Task TestIdempotenceDuplicateRequest()
        {
            string body = idempotenceDepulicateFailureJson;
            string idempotenceKey = Guid.NewGuid().ToString();
            IDictionary<string, string> responseHeaders = new Dictionary<string, string>(1);
            responseHeaders.Add("Location", "http://localhost/v1/20000/payments/000002000020142549460000100001");
            IDictionary<string, string> requestHeaders = new Dictionary<string, string>();

            CallContext context = new CallContext().WithIdempotenceKey(idempotenceKey);
            using (MockServer host = new MockServer(Port, "/v1/20000/payments", ((request, response, arg3) =>
            {
                RecordRequest((HttpStatusCode)409, request, requestHeaders, response, responseHeaders);
                response.StatusCode = 409;
                return body;
            })))
            using (Client client = CreateClient())
            {
                try
                {
                    CreatePaymentRequest request = CreateRequest();

                    await client.Merchant("20000").Payments().Create(request, context);

                    Assert.True(false, "Expected DeclinedPaymentException");

                }
                catch (IdempotenceException e)
                {
                    Assert.AreEqual((HttpStatusCode)409, e.StatusCode);
                    Assert.AreEqual(body, e.ResponseBody);
                }
            }
            Assert.AreEqual(idempotenceKey, requestHeaders[("X-GCS-Idempotence-Key")]);

            Assert.AreEqual(idempotenceKey, context.IdempotenceKey);
            Assert.Null(context.IdempotenceRequestTimestamp);
        }
    }
}
