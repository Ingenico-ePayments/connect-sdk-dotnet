using System;
using NUnit.Framework;
using Ingenico.Connect.Sdk.Webhooks;
using System.Collections.Generic;
using System.Text;

namespace Ingenico.Connect.Sdk
{
    public class WebhooksHelperTest
    {
        const string BadVersionJson = @"{
  ""apiVersion"": ""v0"",
  ""id"": ""8ee793f6-4553-4749-85dc-f2ef095c5ab0"",
  ""created"": ""2017-02-02T11:24:14.040+0100"",
  ""merchantId"": ""20000"",
  ""type"": ""payment.paid"",
  ""payment"": {
    ""id"": ""00000200000143570012"",
    ""paymentOutput"": {
      ""amountOfMoney"": {
        ""amount"": 1000,
        ""currencyCode"": ""EUR""
      },
      ""references"": {
        ""paymentReference"": ""200001681810""
      },
      ""paymentMethod"": ""bankTransfer"",
      ""bankTransferPaymentMethodSpecificOutput"": {
        ""paymentProductId"": 11
      }
    },
    ""status"": ""PAID"",
    ""statusOutput"": {
      ""isCancellable"": false,
      ""statusCategory"": ""COMPLETED"",
      ""statusCode"": 1000,
      ""statusCodeChangeDateTime"": ""20170202112414"",
      ""isAuthorized"": true
    }
  }
}";
        const string GoodVersionJson = @"{
  ""apiVersion"": ""v1"",
  ""id"": ""8ee793f6-4553-4749-85dc-f2ef095c5ab0"",
  ""created"": ""2017-02-02T11:24:14.040+0100"",
  ""merchantId"": ""20000"",
  ""type"": ""payment.paid"",
  ""payment"": {
    ""id"": ""00000200000143570012"",
    ""paymentOutput"": {
      ""amountOfMoney"": {
        ""amount"": 1000,
        ""currencyCode"": ""EUR""
      },
      ""references"": {
        ""paymentReference"": ""200001681810""
      },
      ""paymentMethod"": ""bankTransfer"",
      ""bankTransferPaymentMethodSpecificOutput"": {
        ""paymentProductId"": 11
      }
    },
    ""status"": ""PAID"",
    ""statusOutput"": {
      ""isCancellable"": false,
      ""statusCategory"": ""COMPLETED"",
      ""statusCode"": 1000,
      ""statusCodeChangeDateTime"": ""20170202112414"",
      ""isAuthorized"": true
    }
  }
}";

        const string KeyId = "dummy-key-id";
        const string SecretKey = "hello+world";

        const string KeyIdHeader = "X-GCS-KeyId";
        const string SignatureGood = "2S7doBj/GnJnacIjSJzr5fxGM5xmfQyFAwxv1I53ZEk=";
        const string SignatureWrongApi = "O5FDUZyrDO+9fuQ1hD187HRbJLkUlBEht2eAL9jV/kU=";
        const string SignatureHeader = "X-GCS-Signature";

        [TestCase]
        public void TestUnmarshalApiVersionMismatch()
        {
            var store = InMemorySecretKeyStore.Instance;
            store.StoreSecretKey(KeyId, SecretKey);
            var marshaller = DefaultImpl.DefaultMarshaller.Instance;
            var helper = new WebhooksHelper(marshaller, store);

            // the signature is created with Unix line breaks, so replace any Windows line break
            var bodyStream = BadVersionJson.Replace("\r\n", "\n");

            Assert.Throws(typeof(ApiVersionMismatchException), () => helper.Unmarshal(bodyStream, new List<RequestHeader> { new RequestHeader(KeyIdHeader, KeyId), new RequestHeader(SignatureHeader, SignatureWrongApi) }));
        }

        [TestCase]
        public void TestUnmarshalNoSecretKeyAvailable()
        {
            var store = InMemorySecretKeyStore.Instance;
            var marshaller = DefaultImpl.DefaultMarshaller.Instance;
            var helper = new WebhooksHelper(marshaller, store);
            Assert.Throws(typeof(SecretKeyNotAvailableException), () => helper.Unmarshal(GoodVersionJson, new List<RequestHeader> { new RequestHeader(KeyIdHeader, KeyId), new RequestHeader(SignatureHeader, SignatureGood) }));
        }

        [TearDown]
        public void TearDown()
        {
            InMemorySecretKeyStore.Instance.Clear();
        }

        [TestCase]
        public void TestUnmarshalMissingHeaders()
        {
            var store = InMemorySecretKeyStore.Instance;
            var marshaller = DefaultImpl.DefaultMarshaller.Instance;
            var helper = new WebhooksHelper(marshaller, store);
            store.StoreSecretKey(KeyId, SecretKey);
            Assert.Throws(typeof(SignatureValidationException), () => helper.Unmarshal(GoodVersionJson, new List<RequestHeader> { }));
        }

        [TestCase]
        public void TestUnmarshalDuplicateHeaders()
        {
            var store = InMemorySecretKeyStore.Instance;
            var marshaller = DefaultImpl.DefaultMarshaller.Instance;
            var helper = new WebhooksHelper(marshaller, store);
            store.StoreSecretKey(KeyId, SecretKey);
            Assert.Throws(typeof(SignatureValidationException), () => helper.Unmarshal(GoodVersionJson, new List<RequestHeader> { new RequestHeader(KeyIdHeader, KeyId), new RequestHeader(SignatureHeader, SignatureGood), new RequestHeader(SignatureHeader, SignatureGood + 1) }));
        }

        [TestCase]
        public void TestUnmarshalSuccess()
        {
            var store = InMemorySecretKeyStore.Instance;

            var marshaller = DefaultImpl.DefaultMarshaller.Instance;

            var helper = new WebhooksHelper(marshaller, store);

            store.StoreSecretKey(KeyId, SecretKey);

            // the signature is created with Unix line breaks, so replace any Windows line break
            var bodyStream = GoodVersionJson.Replace("\r\n", "\n");
            List<RequestHeader> requestHeaders = new List<RequestHeader>{
                new RequestHeader(SignatureHeader, SignatureGood),
                new RequestHeader(KeyIdHeader, KeyId)
            };

            WebhooksEvent anEvent = helper.Unmarshal(bodyStream, requestHeaders);

            Assert.AreEqual("v1", anEvent.ApiVersion);
            Assert.AreEqual("8ee793f6-4553-4749-85dc-f2ef095c5ab0", anEvent.Id);
            Assert.AreEqual("2017-02-02T11:24:14.040+0100", anEvent.Created);
            Assert.AreEqual("20000", anEvent.MerchantId);
            Assert.AreEqual("payment.paid", anEvent.Type);

            Assert.Null(anEvent.Refund);
            Assert.Null(anEvent.Payout);
            Assert.Null(anEvent.Token);

            Assert.NotNull(anEvent.Payment);
            Assert.AreEqual("00000200000143570012", anEvent.Payment.Id);
            Assert.NotNull(anEvent.Payment.PaymentOutput);
            Assert.NotNull(anEvent.Payment.PaymentOutput.AmountOfMoney);
            Assert.AreEqual(1000L, anEvent.Payment.PaymentOutput.AmountOfMoney.Amount);
            Assert.AreEqual("EUR", anEvent.Payment.PaymentOutput.AmountOfMoney.CurrencyCode);
            Assert.NotNull(anEvent.Payment.PaymentOutput.References);
            Assert.AreEqual("200001681810", anEvent.Payment.PaymentOutput.References.PaymentReference);
            Assert.AreEqual("bankTransfer", anEvent.Payment.PaymentOutput.PaymentMethod);

            Assert.Null(anEvent.Payment.PaymentOutput.CardPaymentMethodSpecificOutput);
            Assert.Null(anEvent.Payment.PaymentOutput.CashPaymentMethodSpecificOutput);
            Assert.Null(anEvent.Payment.PaymentOutput.DirectDebitPaymentMethodSpecificOutput);
            Assert.Null(anEvent.Payment.PaymentOutput.InvoicePaymentMethodSpecificOutput);
            Assert.Null(anEvent.Payment.PaymentOutput.RedirectPaymentMethodSpecificOutput);
            Assert.Null(anEvent.Payment.PaymentOutput.SepaDirectDebitPaymentMethodSpecificOutput);
            Assert.NotNull(anEvent.Payment.PaymentOutput.BankTransferPaymentMethodSpecificOutput);
            Assert.AreEqual(11, anEvent.Payment.PaymentOutput.BankTransferPaymentMethodSpecificOutput.PaymentProductId);

            Assert.AreEqual("PAID", anEvent.Payment.Status);
            Assert.NotNull(anEvent.Payment.StatusOutput);
            Assert.AreEqual(false, anEvent.Payment.StatusOutput.IsCancellable);
            Assert.AreEqual("COMPLETED", anEvent.Payment.StatusOutput.StatusCategory);
            Assert.AreEqual(1000, anEvent.Payment.StatusOutput.StatusCode);
            Assert.AreEqual("20170202112414", anEvent.Payment.StatusOutput.StatusCodeChangeDateTime);
            Assert.AreEqual(true, anEvent.Payment.StatusOutput.IsAuthorized);
        }

        private string Repeat(string s, int times)
        {
            StringBuilder sb = new StringBuilder(times * s.Length);
            for (int i = 0; i < times; i++)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }

        [TestCase]
        public void TestCompareWithoutTimingLeak()
        {

            string signature = Guid.NewGuid().ToString();
            string large = Repeat(signature, 100);

            Assert.False("abc".CompareWithoutTimingLeak(signature));
            Assert.False(signature.CompareWithoutTimingLeak(signature + "1"));
            Assert.False((signature + "1").CompareWithoutTimingLeak(signature));
            Assert.False(signature.ToUpper().CompareWithoutTimingLeak(signature.ToLower()));
            Assert.False(signature.ToLower().CompareWithoutTimingLeak(signature.ToUpper()));

            Assert.False("abc".CompareWithoutTimingLeak(large));
            Assert.False(large.CompareWithoutTimingLeak(large + "1"));
            Assert.False((large + "1").CompareWithoutTimingLeak(large));
            Assert.False(large.ToUpper().CompareWithoutTimingLeak(large.ToLower()));
            Assert.False(large.ToLower().CompareWithoutTimingLeak(large.ToUpper()));

            Assert.False(large.CompareWithoutTimingLeak(signature));
            Assert.False(signature.CompareWithoutTimingLeak(large));
        }
    }
}
