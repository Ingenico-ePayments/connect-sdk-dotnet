using NUnit.Framework;

namespace Ingenico.Connect.Sdk.Logging
{
    [TestFixture]
    public class LoggingUtilTest
    {
        const string noObfuscation = @"{
    ""order"": {
        ""amountOfMoney"": {
            ""currencyCode"": ""EUR"",
            ""amount"": 1000
        },
        ""customer"": {
            ""locale"": ""nl_NL"",
            ""billingAddress"": {
                ""countryCode"": ""NL""
            }
        }
    },
    ""bankTransferPaymentMethodSpecificInput"": {
        ""paymentProductId"": 11
    }
}";
        const string binObfuscated = @"{
    ""bin"": ""123456**""
}";
        const string binUnobfuscated = @"{
    ""bin"": ""12345678""
}";
        const string cardObfuscated = @"{
    ""order"": {
        ""amountOfMoney"": {
            ""currencyCode"": ""CAD"",
            ""amount"": 2345
        },
        ""customer"": {
            ""billingAddress"": {
                ""countryCode"": ""CA""
            }
        }
    },
    ""cardPaymentMethodSpecificInput"": {
        ""paymentProductId"": 1,
        ""card"": {
            ""cvv"": ""***"",
            ""cardNumber"": ""************3456"",
            ""expiryDate"": ""**20""
        }
    }
}";
        const string cardUnObfuscated = @"{
    ""order"": {
        ""amountOfMoney"": {
            ""currencyCode"": ""CAD"",
            ""amount"": 2345
        },
        ""customer"": {
            ""billingAddress"": {
                ""countryCode"": ""CA""
            }
        }
    },
    ""cardPaymentMethodSpecificInput"": {
        ""paymentProductId"": 1,
        ""card"": {
            ""cvv"": ""123"",
            ""cardNumber"": ""1234567890123456"",
            ""expiryDate"": ""1220""
        }
    }
}";
        const string ibanObfuscated = @"{
    ""sepaDirectDebit"": {
        ""mandate"": {
            ""bankAccountIban"": {
                ""iban"": ""**************4567""
            },
            ""debtor"": {
                ""surname"": ""Jones""
            },
            ""isRecurring"": false
        },
        ""customer"": {
            ""billingAddress"": {
                ""countryCode"": ""NL""
            }
        }
    },
    ""paymentProductId"": 770
}";
        const string ibanUnobfuscated = @"{
    ""sepaDirectDebit"": {
        ""mandate"": {
            ""bankAccountIban"": {
                ""iban"": ""NL00INGB0001234567""
            },
            ""debtor"": {
                ""surname"": ""Jones""
            },
            ""isRecurring"": false
        },
        ""customer"": {
            ""billingAddress"": {
                ""countryCode"": ""NL""
            }
        }
    },
    ""paymentProductId"": 770
}";
        const string noObjectObfuscationUnobfuscated = @"{
    ""value"" : true,
    ""value"" : {
    }
}";
        const string noObjectObfuscationObfuscated = @"{
    ""value"" : ****,
    ""value"" : {
    }
}";

        [TestCase]
        public void TestObfuscateBodyWithNullBody()
        {
            string body = null;

            string obfuscatedBody = LoggingUtil.ObfuscateBody(body);

            Assert.Null(obfuscatedBody);
        }

        [TestCase]
        public void TestObfuscateBodyWithEmptyBody()
        {
            string body = "";

            string obfuscatedBody = LoggingUtil.ObfuscateBody(body);

            Assert.AreEqual(body, obfuscatedBody);
        }

        [TestCase]
        public void TestObfuscateBodyWithCard()
        {
            CheckObfuscatedBodyWithMatches(cardUnObfuscated, cardObfuscated);
        }

        [TestCase]
        public void TestObfuscateBodyWithIban()
        {
            CheckObfuscatedBodyWithMatches(ibanUnobfuscated, ibanObfuscated);
        }

        [TestCase]
        public void TestObfuscateBodyWithBin()
        {
            CheckObfuscatedBodyWithMatches(binUnobfuscated, binObfuscated);
        }

        [TestCase]
        public void TestObfuscateBodyWithNoMatches()
        {
            CheckObfuscatedBodyWithMatches(noObfuscation);
        }

        [TestCase]
        public void TestObfuscateBodyWithObject()
        {
            CheckObfuscatedBodyWithMatches(noObjectObfuscationUnobfuscated, noObjectObfuscationObfuscated);
        }

        [TestCase]
        public void TestObfuscateHeader()
        {
            CheckObfuscateHeaderWithMatch("Authorization", "Basic QWxhZGRpbjpPcGVuU2VzYW1l", "********");
            CheckObfuscateHeaderWithMatch("authorization", "Basic QWxhZGRpbjpPcGVuU2VzYW1l", "********");
            CheckObfuscateHeaderWithMatch("AUTHORIZATION", "Basic QWxhZGRpbjpPcGVuU2VzYW1l", "********");

            CheckObfuscateHeaderWithMatch("X-GCS-Authentication-Token", "foobar", "********");
            CheckObfuscateHeaderWithMatch("x-gcs-authentication-token", "foobar", "********");
            CheckObfuscateHeaderWithMatch("X-GCS-AUTHENTICATION-TOKEN", "foobar", "********");

            CheckObfuscateHeaderWithMatch("X-GCS-CallerPassword", "foobar", "********");
            CheckObfuscateHeaderWithMatch("x-gcs-callerpassword", "foobar", "********");
            CheckObfuscateHeaderWithMatch("X-GCS-CALLERPASSWORD", "foobar", "********");

            CheckObfuscateHeaderWithNoMatch("Content-Type", "application/json");
            CheckObfuscateHeaderWithNoMatch("content-type", "application/json");
            CheckObfuscateHeaderWithNoMatch("CONTENT-TYPE", "application/json");
        }

        void CheckObfuscatedBodyWithMatches(string body, string expected)
        {
            string obfuscatedBody = LoggingUtil.ObfuscateBody(body);

            Assert.AreEqual(expected, obfuscatedBody);
        }

        void CheckObfuscatedBodyWithMatches(string body)
        {
            string obfuscatedBody = LoggingUtil.ObfuscateBody(body);

            Assert.AreEqual(body, obfuscatedBody);
        }

        void CheckObfuscateHeaderWithMatch(string name, string originalValue, string expectedObfuscatedValue)
        {
            string obfuscatedValue = LoggingUtil.ObfuscateHeader(name, originalValue);

            Assert.AreEqual(expectedObfuscatedValue, obfuscatedValue);
        }

        void CheckObfuscateHeaderWithNoMatch(string name, string originalValue)
        {
            string obfuscatedValue = LoggingUtil.ObfuscateHeader(name, originalValue);

            Assert.AreEqual(originalValue, obfuscatedValue);
        }
    }
}
