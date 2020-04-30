using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using MockHttpServer;
using System.Net;
using Ingenico.Connect.Sdk.Domain.Services;
using System.Threading.Tasks;
using System.Linq;
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Merchant.Services;

namespace Ingenico.Connect.Sdk.DefaultImpl
{
    [TestFixture]
    public class DefaultConnectionLoggerTest
    {
        const int Port = 5357;

        const string convertAmountJson = @"{
   ""convertedAmount"" : 4547504
}";

        readonly string convertAmountRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'GET'
  uri:          '/v1/1234/services/convert/amount?source=EUR&target=USD&amount=1000'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + @"[^']*" + Regex.Escape(@"'");

        readonly string convertAmountResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '200'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
   ""convertedAmount"" : 4547504
}'");

        const string createPaymentFailureRejectedJson = @"{
    ""errorId"": ""833dfd83-52ae-419c-b871-9df1278da93e"",
    ""errors"": [
        {
            ""code"": ""430330"",
            ""message"": ""Not authorised"",
            ""httpStatusCode"": 402
        }
    ],
    ""paymentResult"": {
        ""creationOutput"": {
            ""additionalReference"": ""00000200001000059614"",
            ""externalReference"": ""000002000010000596140000100001""
        },
        ""payment"": {
            ""id"": ""000002000010000596140000100001"",
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
                        ""code"": ""430330"",
                        ""requestId"": ""24162"",
                        ""message"": ""Not authorised"",
                        ""httpStatusCode"": 402
                    }
                ],
                ""isCancellable"": false,
                ""statusCategory"": ""UNSUCCESSFUL"",
                ""statusCode"": 100,
                ""statusCodeChangeDateTime"": ""20160310121151"",
                ""isAuthorized"": false
            }
        }
    }
}";

        readonly string createPaymentFailureRejectedRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/v1/1234/payments'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + @"[^']*" + Regex.Escape(@"'
  content-type: 'application/json'
  body:         '{""cardPaymentMethodSpecificInput"":{""card"":{""cvv"":""***"",""cardNumber"":""************3452"",""expiryDate"":""**20""},""paymentProductId"":1},""order"":{""amountOfMoney"":{""amount"":2345,""currencyCode"":""CAD""},""customer"":{""billingAddress"":{""countryCode"":""CA""}}}}'");

        readonly string createPaymentFailureRejectedResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '402'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""errorId"": ""833dfd83-52ae-419c-b871-9df1278da93e"",
    ""errors"": [
        {
            ""code"": ""430330"",
            ""message"": ""Not authorised"",
            ""httpStatusCode"": 402
        }
    ],
    ""paymentResult"": {
        ""creationOutput"": {
            ""additionalReference"": ""00000200001000059614"",
            ""externalReference"": ""000002000010000596140000100001""
        },
        ""payment"": {
            ""id"": ""000002000010000596140000100001"",
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
                        ""code"": ""430330"",
                        ""requestId"": ""24162"",
                        ""message"": ""Not authorised"",
                        ""httpStatusCode"": 402
                    }
                ],
                ""isCancellable"": false,
                ""statusCategory"": ""UNSUCCESSFUL"",
                ""statusCode"": 100,
                ""statusCodeChangeDateTime"": ""20160310121151"",
                ""isAuthorized"": false
            }
        }
    }
}'");

        const string createPaymentJson = @"{
    ""creationOutput"": {
        ""additionalReference"": ""00000012341000059598"",
        ""externalReference"": ""000000123410000595980000100001""
    },
    ""payment"": {
        ""id"": ""000000123410000595980000100001"",
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
                    ""cardNumber"": ""************3456"",
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
            ""statusCategory"": ""PENDING_MERCHANT"",
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20160310094054"",
            ""isAuthorized"": true
        }
    }
}";

        readonly string createPaymentRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/v1/1234/payments'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********"", Content-Type=""application/json""") + @"[^']*" + Regex.Escape(@"'
  content-type: 'application/json'
  body:         '{""cardPaymentMethodSpecificInput"":{""card"":{""cvv"":""***"",""cardNumber"":""************3456"",""expiryDate"":""**20""},""paymentProductId"":1},""order"":{""amountOfMoney"":{""amount"":2345,""currencyCode"":""CAD""},""customer"":{""billingAddress"":{""countryCode"":""CA""}}}}'");

        readonly string createPaymentResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '201'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")(?=('|.*, )Location=""http://localhost/v1/1234/payments/000000123410000595980000100001"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""creationOutput"": {
        ""additionalReference"": ""00000012341000059598"",
        ""externalReference"": ""000000123410000595980000100001""
    },
    ""payment"": {
        ""id"": ""000000123410000595980000100001"",
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
                    ""cardNumber"": ""************3456"",
                    ""expiryDate"": ""**20""
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
            ""statusCategory"": ""PENDING_MERCHANT"",
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20160310094054"",
            ""isAuthorized"": true
        }
    }
}'");
        const string createPaymentUnicodeJson = @"{
    ""creationOutput"": {
        ""additionalReference"": ""00000012341000059598"",
        ""externalReference"": ""000000123410000595980000100001""
    },
    ""payment"": {
        ""id"": ""000000123410000595980000100001"",
        ""paymentOutput"": {
            ""amountOfMoney"": {
                ""amount"": 2345,
                ""currencyCode"": ""CAD""
            },
            ""references"": {
                ""paymentReference"": ""0""
            },
            ""paymentMethod"": ""redirect"",
            ""redirectPaymentMethodSpecificOutput"":{
               ""paymentProductId"":840,
               ""paymentProduct840SpecificOutput"":{
                  ""customerAccount"":{
                     ""firstName"":""Theresa"",
                     ""surname"":""Schröder""
                  },
                  ""customerAddress"":{
                     ""city"":""sittensen"",
                     ""countryCode"":""DE"",
                     ""street"":""Westerberg 25"",
                     ""zip"":""27419""
                  }
               }
            }
        },
        ""status"": ""PENDING_APPROVAL"",
        ""statusOutput"": {
            ""isCancellable"": true,
            ""statusCategory"": ""PENDING_MERCHANT"",
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20160310094054"",
            ""isAuthorized"": true
        }
    }
}";

        readonly string createPaymentUnicodeRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/v1/1234/payments'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********"", Content-Type=""application/json""") + @"[^']*" + Regex.Escape(@"'
  content-type: 'application/json'
  body:         '{""cardPaymentMethodSpecificInput"":{""card"":{""cvv"":""***"",""cardNumber"":""************3456"",""expiryDate"":""**20""},""paymentProductId"":1},""order"":{""amountOfMoney"":{""amount"":2345,""currencyCode"":""CAD""},""customer"":{""billingAddress"":{""countryCode"":""CA""}}}}'");

        readonly string createPaymentUnicodeResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '201'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")(?=('|.*, )Location=""http://localhost/v1/1234/payments/000000123410000595980000100001"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""creationOutput"": {
        ""additionalReference"": ""00000012341000059598"",
        ""externalReference"": ""000000123410000595980000100001""
    },
    ""payment"": {
        ""id"": ""000000123410000595980000100001"",
        ""paymentOutput"": {
            ""amountOfMoney"": {
                ""amount"": 2345,
                ""currencyCode"": ""CAD""
            },
            ""references"": {
                ""paymentReference"": ""0""
            },
            ""paymentMethod"": ""redirect"",
            ""redirectPaymentMethodSpecificOutput"":{
               ""paymentProductId"":840,
               ""paymentProduct840SpecificOutput"":{
                  ""customerAccount"":{
                     ""firstName"":""Theresa"",
                     ""surname"":""Schröder""
                  },
                  ""customerAddress"":{
                     ""city"":""sittensen"",
                     ""countryCode"":""DE"",
                     ""street"":""Westerberg 25"",
                     ""zip"":""27419""
                  }
               }
            }
        },
        ""status"": ""PENDING_APPROVAL"",
        ""statusOutput"": {
            ""isCancellable"": true,
            ""statusCategory"": ""PENDING_MERCHANT"",
            ""statusCode"": 600,
            ""statusCodeChangeDateTime"": ""20160310094054"",
            ""isAuthorized"": true
        }
    }
}'");
        const string createPaymentFailureInvalidCardNumberJson = @"{
    ""errorId"": ""0953f236-9e54-4f23-9556-d66bc757dda8"",
    ""errors"": [
        {
            ""code"": ""21000020"",
            ""requestId"": ""24146"",
            ""message"": ""VALUE **************** OF FIELD CREDITCARDNUMBER DID NOT PASS THE LUHNCHECK"",
            ""httpStatusCode"": 400
        }
    ]
}";

        readonly string createPaymentFailureInvalidCardNumberJsonRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/v1/1234/payments'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + @"[^']*" + Regex.Escape(@"'
  content-type: 'application/json'
  body:         '{""cardPaymentMethodSpecificInput"":{""card"":{""cvv"":""***"",""cardNumber"":""************3456"",""expiryDate"":""**20""},""paymentProductId"":1},""order"":{""amountOfMoney"":{""amount"":2345,""currencyCode"":""CAD""},""customer"":{""billingAddress"":{""countryCode"":""CA""}}}}'");

        readonly string createPaymentFailureInvalidCardNumberJsonResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '400'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""errorId"": ""0953f236-9e54-4f23-9556-d66bc757dda8"",
    ""errors"": [
        {
            ""code"": ""21000020"",
            ""requestId"": ""24146"",
            ""message"": ""VALUE **************** OF FIELD CREDITCARDNUMBER DID NOT PASS THE LUHNCHECK"",
            ""httpStatusCode"": 400
        }
    ]
}'");
        readonly string deleteTokenRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'DELETE'
  uri:          '/v1/1234/tokens/5678'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + @"[^']*" + Regex.Escape(@"'");
        readonly string deleteTokenResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '204'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: ''
  body:         ''");
        
        const string testConnectionJson = @"{
    ""result"": ""OK""
}";

        readonly string testConnectionRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"')") + Regex.Escape(@":
  method:       'GET'
  uri:          '/v1/1234/services/testconnection'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + @"[^']*" + Regex.Escape(@"'");

        readonly string testConnectionResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '200'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""result"": ""OK""
}'");

        readonly string binaryRequestRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'POST'
  uri:          '/binaryRequest'
  headers:      'X-GCS-ServerMetaInfo=""") + @"[^""]*" + Regex.Escape(@""", Date=""") + @"[^""]+" + Regex.Escape(@""", Authorization=""********""") + @"[^']*" + Regex.Escape(@"'
  content-type: 'multipart/form-data; boundary=") + @".*" + Regex.Escape(@"'
  body:         '<binary content>'");

        readonly string binaryRequestResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '204'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: ''
  body:         ''");

        readonly string binaryResponseRequest = Regex.Escape(@"Outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"'):
  method:       'GET'
  uri:          '/binaryContent'
  headers:      '") + @"[^']*" + Regex.Escape(@"'");

        readonly string binaryResponseResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '200'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/octet-stream'
  body:         '<binary content>'");

        const string unknownServerErrorJson = @"{
    ""errorId"": ""fbff1179-7ba4-4894-9021-d8a0011d23a7"",
    ""errors"": [
        {
            ""code"": ""9999"",
            ""message"": ""UNKNOWN_SERVER_ERROR"",
            ""httpStatusCode"": 500
        }
    ]
}";

        readonly string unknownServerErrorResponse = @"" + Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '500'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'application/json'
  body:         '{
    ""errorId"": ""fbff1179-7ba4-4894-9021-d8a0011d23a7"",
    ""errors"": [
        {
            ""code"": ""9999"",
            ""message"": ""UNKNOWN_SERVER_ERROR"",
            ""httpStatusCode"": 500
        }
    ]
}'");
        
        const string notFoundHtml = @"Not Found";
        readonly string notFoundResponse = Regex.Escape(@"Incoming response (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"' + '") + @"[0-9]*" + Regex.Escape(@"' ms):
  status-code:  '404'
  headers:      ") + @"(?=('|.*, )Server=""[^""]*"")(?=('|.*, )Dummy="""")(?=('|.*, )Date=""[^""]*"")'[^']*'" + Regex.Escape(@"
  content-type: 'text/html'
  body:         'Not Found'");
        readonly string genericError = Regex.Escape(@"Error occurred for outgoing request (requestId='") + @"([-a-zA-Z0-9]+)" + Regex.Escape(@"')");

        [TestCase]
        public async Task TestLoggingTestConnection()
        {
            // GET with no query params
            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);

                       return testConnectionJson;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);

                TestConnection response = await client.Merchant("1234").Services().Testconnection();

                Assert.That(response, Is.Not.Null);
                Assert.That("OK", Is.EqualTo(response.Result));

            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, testConnectionRequest, testConnectionResponse);
        }

        [TestCase]
        public async Task TestLoggingConvertAmount()
        {
            // GET with query params

            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/services/convert/amount", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);

                       return convertAmountJson;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);
                ConvertAmountParams query = new ConvertAmountParams();
                query.Amount = 1000L;
                query.Source = "EUR";
                query.Target = "USD";
                ConvertAmount response = await client.Merchant("1234").Services().ConvertAmount(query);

                Assert.NotNull(response);
                Assert.NotNull(response.ConvertedAmount);
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(responseEntry.Message);
            Assert.Null(responseEntry.Thrown);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, convertAmountRequest, convertAmountResponse);
        }

        [TestCase]
        public async Task TestDeleteToken()
        {
            // POST with no request body and a void response

            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(5357, "/v1/1234/tokens/5678", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)204, new Dictionary<string, string>(), response, contentType: null);
                       return null;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);
                await client.Merchant("1234").Tokens().Delete("5678", null);

            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(responseEntry.Message);
            Assert.Null(responseEntry.Thrown);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, deleteTokenRequest, deleteTokenResponse);
        }

        [TestCase]
        public async Task TestLoggingCreatePayment()
        {
            // POST with a success (201) response
            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/payments", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)201, new Dictionary<string, string>(), response, "http://localhost/v1/1234/payments/000000123410000595980000100001");

                       return createPaymentJson;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);

                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.CurrencyCode = "CAD";
                amountOfMoney.Amount = 2345L;

                Address billingAddress = new Address();
                billingAddress.CountryCode = "CA";

                Customer customer = new Customer();
                customer.BillingAddress = billingAddress;

                Order order = new Order();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                Card card = new Card();
                card.Cvv = "123";
                card.CardNumber = "1234567890123456";
                card.ExpiryDate = "1220";

                CardPaymentMethodSpecificInput paymentMethodSpecificInput = new CardPaymentMethodSpecificInput();
                paymentMethodSpecificInput.PaymentProductId = 1;
                paymentMethodSpecificInput.Card = card;

                CreatePaymentRequest request = new CreatePaymentRequest();
                request.Order = order;
                request.CardPaymentMethodSpecificInput = paymentMethodSpecificInput;

                CreatePaymentResponse response = await client.Merchant("1234").Payments().Create(request);

                Assert.NotNull(response);
                Assert.NotNull(response.Payment);
                Assert.NotNull(response.Payment.Id);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, createPaymentRequest, createPaymentResponse);
        }

        [TestCase]
        public async Task TestLoggingCreatePaymentUnicode()
        {
            // POST with a success (201) response
            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/payments", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)201, new Dictionary<string, string>(), response, "http://localhost/v1/1234/payments/000000123410000595980000100001");

                       return createPaymentUnicodeJson;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);

                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.CurrencyCode = "CAD";
                amountOfMoney.Amount = 2345L;

                Address billingAddress = new Address();
                billingAddress.CountryCode = "CA";

                Customer customer = new Customer();
                customer.BillingAddress = billingAddress;

                Order order = new Order();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                Card card = new Card();
                card.Cvv = "123";
                card.CardNumber = "1234567890123456";
                card.ExpiryDate = "1220";

                CardPaymentMethodSpecificInput paymentMethodSpecificInput = new CardPaymentMethodSpecificInput();
                paymentMethodSpecificInput.PaymentProductId = 1;
                paymentMethodSpecificInput.Card = card;

                CreatePaymentRequest request = new CreatePaymentRequest();
                request.Order = order;
                request.CardPaymentMethodSpecificInput = paymentMethodSpecificInput;

                CreatePaymentResponse response = await client.Merchant("1234").Payments().Create(request);

                Assert.NotNull(response);
                Assert.NotNull(response.Payment);
                Assert.NotNull(response.Payment.Id);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, createPaymentUnicodeRequest, createPaymentUnicodeResponse);
        }

        [TestCase]
        public void TestCreatePaymentInvalidCardNumber()
        {
            // an exception is thrown after logging the response

            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/payments", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)400, new Dictionary<string, string>(), response);

                       return createPaymentFailureInvalidCardNumberJson;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);

                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.CurrencyCode = "CAD";
                amountOfMoney.Amount = 2345L;

                Address billingAddress = new Address();
                billingAddress.CountryCode = "CA";

                Customer customer = new Customer();
                customer.BillingAddress = billingAddress;

                Order order = new Order();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                Card card = new Card();
                card.Cvv = "123";
                card.CardNumber = "1234567890123456";
                card.ExpiryDate = "1220";

                CardPaymentMethodSpecificInput paymentMethodSpecificInput = new CardPaymentMethodSpecificInput();
                paymentMethodSpecificInput.PaymentProductId = 1;
                paymentMethodSpecificInput.Card = card;

                CreatePaymentRequest request = new CreatePaymentRequest();
                request.Order = order;
                request.CardPaymentMethodSpecificInput = paymentMethodSpecificInput;

                Assert.CatchAsync(typeof(ValidationException), async () => await client.Merchant("1234").Payments().Create(request));
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, createPaymentFailureInvalidCardNumberJsonRequest, createPaymentFailureInvalidCardNumberJsonResponse);
        }

        [TestCase]
        public void TestCreatePaymentRejected()
        {
            // an exception is thrown after logging the response

            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/payments", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)402, new Dictionary<string, string>(), response);

                       return createPaymentFailureRejectedJson;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);

                AmountOfMoney amountOfMoney = new AmountOfMoney();
                amountOfMoney.CurrencyCode = "CAD";
                amountOfMoney.Amount = 2345L;

                Address billingAddress = new Address();
                billingAddress.CountryCode = "CA";

                Customer customer = new Customer();
                customer.BillingAddress = billingAddress;

                Order order = new Order();
                order.AmountOfMoney = amountOfMoney;
                order.Customer = customer;

                Card card = new Card();
                card.Cvv = "123";
                card.CardNumber = "1234567890123452";
                card.ExpiryDate = "1220";

                CardPaymentMethodSpecificInput paymentMethodSpecificInput = new CardPaymentMethodSpecificInput();
                paymentMethodSpecificInput.PaymentProductId = 1;
                paymentMethodSpecificInput.Card = card;

                CreatePaymentRequest request = new CreatePaymentRequest();
                request.Order = order;
                request.CardPaymentMethodSpecificInput = paymentMethodSpecificInput;

                Assert.CatchAsync(typeof(DeclinedPaymentException), async () => await client.Merchant("1234").Payments().Create(request));
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, createPaymentFailureRejectedRequest, createPaymentFailureRejectedResponse);
        }

        [TestCase]
        public async Task TestBinaryRequestWithKnownLength()
        {
            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/binaryRequest", (request, response, arg3) =>
                    {
                        AssignResponse((HttpStatusCode)204, new Dictionary<string, string>(), response, contentType: null);
                        return null;
                    }))
            using (Communicator communicator = CreateCommunicator())
            {
                communicator.EnableLogging(logger);

                byte[] data = new byte[1024];
                new Random().NextBytes(data);

                UploadableFile file = new UploadableFile("dummyFile", new MemoryStream(data), "application/octetstream", data.Length);
                MultipartFormDataObject multipart = new MultipartFormDataObject();
                multipart.AddFile("file", file);

                await communicator.Post<object>("/binaryRequest", new List<IRequestHeader>(), null, multipart, null);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, binaryRequestRequest, binaryRequestResponse);
        }

        [TestCase]
        public async Task TestBinaryRequestWithUnknownLength()
        {
            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/binaryRequest", (request, response, arg3) =>
                    {
                        AssignResponse((HttpStatusCode)204, new Dictionary<string, string>(), response, contentType: null);
                        return null;
                    }))
            using (Communicator communicator = CreateCommunicator())
            {
                communicator.EnableLogging(logger);

                byte[] data = new byte[1024];
                new Random().NextBytes(data);

                UploadableFile file = new UploadableFile("dummyFile", new MemoryStream(data), "application/octetstream");
                MultipartFormDataObject multipart = new MultipartFormDataObject();
                multipart.AddFile("file", file);

                await communicator.Post<object>("/binaryRequest", new List<IRequestHeader>(), null, multipart, null);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, binaryRequestRequest, binaryRequestResponse);
        }

        [TestCase]
        public async Task TestBinaryResponse()
        {
            TestLogger logger = new TestLogger();

            byte[] data = new byte[10];
            new Random().NextBytes(data);

            using (MockServer host = new MockServer(Port, "/binaryContent", (request, response, arg3) =>
                    {
                        AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response, null, "application/octet-stream");
                        new MemoryStream(data).CopyTo(response.OutputStream);
                    }))
            using (IConnection connection = CreateConnection())
            {
                connection.EnableLogging(logger);

                var uriBuilder = new UriBuilder("http", "localhost");
                uriBuilder.Port = 5357;
                uriBuilder.Path = "/binaryContent";
                await connection.Get<object>(uriBuilder.Uri, new List<IRequestHeader>(), (statusCode, stream, headers) => {
                    MemoryStream memStream = new MemoryStream();
                    stream.CopyTo(memStream);

                    Assert.That(statusCode, Is.EqualTo(HttpStatusCode.OK));
                    Assert.That(memStream.ToArray(), Is.EqualTo(data));

                    return null;
                });
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, binaryResponseRequest, binaryResponseResponse);
        }

        [TestCase]
        public async Task TestVoidContent()
        {
            // reuse delete token
            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/tokens/5678", (request, response, arg3) =>
                    {
                        AssignResponse((HttpStatusCode)204, new Dictionary<string, string>(), response, contentType: null);
                        return null;
                    }))
            using (Communicator communicator = CreateCommunicator())
            {
                communicator.EnableLogging(logger);

                await communicator.Delete("/v1/1234/tokens/5678", new List<IRequestHeader>(), null, (stream, headers) => {
                    Assert.That(stream.ReadByte(), Is.EqualTo(-1));
                }, null);
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.That(requestEntry.Message, Is.Not.Null);
            Assert.That(requestEntry.Thrown, Is.Null);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.That(responseEntry.Message, Is.Not.Null);
            Assert.That(responseEntry.Thrown, Is.Null);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, deleteTokenRequest, deleteTokenResponse);
        }

        [TestCase]
        public void TestLoggingUnknownServerError()
        {
            // an exception is thrown after logging the response

            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)500, new Dictionary<string, string>(), response);

                       return unknownServerErrorJson;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);

                Assert.CatchAsync(typeof(GlobalCollectException), async () => await client.Merchant("1234").Services().Testconnection());
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(responseEntry.Message);
            Assert.Null(responseEntry.Thrown);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, testConnectionRequest, unknownServerErrorResponse);
        }

        [TestCase]
        public void TestNonJson()
        {
            // an exception is thrown after logging the response

            TestLogger logger = new TestLogger();

            using (MockServer host = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)404, new Dictionary<string, string>(), response, contentType: "text/html");

                       return notFoundHtml;
                   }))
            using (Client client = CreateClient())
            {
                client.EnableLogging(logger);

                Assert.CatchAsync(typeof(NotFoundException), async () => await client.Merchant("1234").Services().Testconnection());
            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            TestLoggerEntry responseEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(responseEntry.Message);
            Assert.Null(responseEntry.Thrown);

            AssertRequestAndResponse(requestEntry.Message, responseEntry.Message, testConnectionRequest, notFoundResponse);
        }

        [TestCase]
        public void TestReadTimeout()
        {
            // an exception is thrown before logging the response

            TestLogger logger = new TestLogger();
            using (Client client = CreateClient(1, 10))
            using (MockServer host = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);
                       System.Threading.Thread.Sleep(500);

                       return testConnectionJson;
                   }))
            {
                client.EnableLogging(logger);
                Assert.That(async () => await client.Merchant("1234").Services().Testconnection(),
                            Throws.Exception.TypeOf(typeof(CommunicationException))
                            .And.InnerException.TypeOf(typeof(TaskCanceledException)));

            }
            Assert.That(logger.Entries, Has.Count.EqualTo(2));

            TestLoggerEntry requestEntry = logger.Entries.First();
            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            TestLoggerEntry errorEntry = logger.Entries.ElementAt(1);

            Assert.NotNull(errorEntry.Message);
            Assert.NotNull(errorEntry.Thrown);

            AssertRequestAndError(requestEntry.Message, errorEntry.Message, testConnectionRequest);
        }

        [TestCase]
        public async Task TestLogRequestOnly()
        {
            // logging is disabled after the request is logged but before the response is logged

            TestLogger logger = new TestLogger();
            using (Client client = CreateClient())
            using (MockServer host = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);
                       client.DisableLogging();

                       return testConnectionJson;
                   }))
            {
                client.EnableLogging(logger);

                TestConnection response = await client.Merchant("1234").Services().Testconnection();

                Assert.NotNull(response);
                Assert.AreEqual("OK", response.Result);
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(1));
            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            AssertRequest(requestEntry.Message, testConnectionRequest);
        }

        [TestCase]
        public async Task TestLogResponseOnly()
        {
            // logging is disabled after the request is logged but before the response is logged

            TestLogger logger = new TestLogger();
            using (Client client = CreateClient())
            using (MockServer host = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);
                       client.EnableLogging(logger);

                       return testConnectionJson;
                   }))
            {
                TestConnection response = await client.Merchant("1234").Services().Testconnection();

                Assert.NotNull(response);
                Assert.AreEqual("OK", response.Result);
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(1));

            TestLoggerEntry requestEntry = logger.Entries.First();

            Assert.NotNull(requestEntry.Message);
            Assert.Null(requestEntry.Thrown);

            AssertResponse(requestEntry.Message, testConnectionResponse);
        }

        [TestCase]
        public void TestLogErrorOnly()
        {
            // logging is enabled after the request is logged but before the error is logged

            TestLogger logger = new TestLogger();
            using (Client client = CreateClient(1, 100))
            using (MockServer host = new MockServer(Port, "/v1/1234/services/testconnection", (request, response, arg3) =>
                   {
                       AssignResponse((HttpStatusCode)200, new Dictionary<string, string>(), response);
                       client.EnableLogging(logger);
                       System.Threading.Thread.Sleep(500);

                       return testConnectionJson;
                   }))
            {
                Assert.That(async () => await client.Merchant("1234").Services().Testconnection(),
                            Throws.Exception.TypeOf(typeof(CommunicationException))
                            .And.InnerException.TypeOf(typeof(TaskCanceledException)));
            }

            Assert.That(logger.Entries, Has.Count.EqualTo(1));

            TestLoggerEntry errorEntry = logger.Entries.First();

            Assert.NotNull(errorEntry.Message);
            Assert.NotNull(errorEntry.Thrown);

            AssertError(errorEntry.Message);
        }

        string AssertRequestAndError(string requestMessage, string errorMessage, string requestPattern)
        {
            string requestId = AssertRequest(requestMessage, requestPattern);
            requestId = AssertError(errorMessage, requestId);
            return requestId;
        }

        IConnection CreateConnection(int connectTimeout = 50000, int socketTimeout = 50000)
        {
            // Connect timeout not implemented
            return new DefaultConnection(TimeSpan.FromMilliseconds(socketTimeout), 2);
        }

        Communicator CreateCommunicator(int connectTimeout = 50000, int socketTimeout = 50000)
        {
            IConnection connection = CreateConnection(connectTimeout, socketTimeout);
            IAuthenticator authenticator = new DefaultAuthenticator(AuthorizationType.V1HMAC, "apiKey", "secret");
            MetaDataProvider metaDataProvider = new MetaDataProvider("Ingenico");
            var uriBuilder = new UriBuilder("http", "localhost");
            uriBuilder.Port = 5357;
            Session session = new Session(uriBuilder.Uri, connection, authenticator, metaDataProvider);
            return Factory.CreateCommunicator(session);
        }

        Client CreateClient(int connectTimeout = 50000, int socketTimeout = 50000)
        {
            Communicator communicator = CreateCommunicator(connectTimeout, socketTimeout);
            Client client = Factory.CreateClient(communicator);
            return client;
        }

        string AssertRequestAndResponse(string requestMessage, string responseMessage, string requestPattern, string responsePattern)
        {
            string requestId = AssertRequest(requestMessage, requestPattern);
            requestId = AssertResponse(responseMessage, responsePattern, requestId);
            return requestId;
        }

        string AssertRequest(string requestMessage, string requestPattern)
        {
            Assert.That(requestMessage, Does.Match(requestPattern));
            Match requestMatches = Regex.Match(requestMessage, requestPattern);
            string requestId = requestMatches.Groups[1].Value;
            return requestId;
        }

        string AssertResponse(string responseMessage, string responsePattern, string requestId = null)
        {
            Assert.That(responseMessage, Does.Match(responsePattern));
            Match responseMatch = Regex.Match(responseMessage, responsePattern);

            string responseRequestId = responseMatch.Groups[1].Value;
            if (requestId != null)
            {
                Assert.AreEqual(requestId, responseRequestId, "response requestId '" + responseRequestId + "' does not match request requestId '" + requestId + "'");
            }
            else {
                requestId = responseRequestId;
            }
            return requestId;
        }

        string AssertError(string message, string requestId = null)
        {
            Assert.That(message, Does.Match(genericError));

            Match responseMatch = Regex.Match(message, genericError);

            string errorRequestId = responseMatch.Groups[1].Value;

            if (requestId != null)
            {
                Assert.AreEqual(errorRequestId, requestId, "error requestId '" + errorRequestId + "' does not match earlier requestId '" + requestId + "'");
            }
            else {
                errorRequestId = requestId;
            }

            return errorRequestId;
        }

        static void AssignResponse(HttpStatusCode statusCode, IDictionary additionalHeaders, HttpListenerResponse response, string location = null, string contentType = "application/json")
        {
            response.StatusCode = (int)statusCode;
            if (contentType != null)
            {
                response.Headers.Add("Content-Type", contentType);
            }

            response.Headers.Add("Dummy", (string)null);

            if (location != null)
            {
                response.Headers.Add("Location", location);
            }
            foreach (KeyValuePair<string, string> entry in additionalHeaders)
            {
                response.Headers.Add(entry.Key, entry.Value);
            }
        }

        sealed class TestLogger : Logging.ICommunicatorLogger
        {
            public IList<TestLoggerEntry> Entries { get; set; } = new List<TestLoggerEntry>();

            public void Log(string message)
            {
                this.Log(message, null);
            }

            public void Log(string message, Exception thrown)
            {
                Entries.Add(new TestLoggerEntry(message, thrown));
            }
        }

        sealed class TestLoggerEntry
        {
            public string Message { get; private set; }
            public Exception Thrown { get; private set; }
            public TestLoggerEntry(string message, Exception thrown)
            {
                this.Message = message;
                this.Thrown = thrown;
            }
        }
    }
}
