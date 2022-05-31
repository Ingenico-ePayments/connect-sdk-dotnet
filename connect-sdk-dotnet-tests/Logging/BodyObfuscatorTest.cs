using NUnit.Framework;

namespace Ingenico.Connect.Sdk.Logging
{
    [TestFixture]
    public class BodyObfuscatorTest
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
        const string cardObfuscatedCustom = @"{
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
            ""cardNumber"": ""123456******3456"",
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

            string obfuscatedBody = BodyObfuscator.DefaultObfuscator.ObfuscateBody(body);

            Assert.Null(obfuscatedBody);
        }

        [TestCase]
        public void TestObfuscateBodyWithEmptyBody()
        {
            string body = "";

            string obfuscatedBody = BodyObfuscator.DefaultObfuscator.ObfuscateBody(body);

            Assert.AreEqual(body, obfuscatedBody);
        }

        [TestCase]
        public void TestObfuscateBodyWithCard()
        {
            CheckObfuscatedBodyWithMatches(cardUnObfuscated, cardObfuscated);
        }

        [TestCase]
        public void TestObfuscateBodyWithCustomCardRule()
        {
            string obfuscationRule(string value) => KeepFirst6AndLast4(value);
            BodyObfuscator bodyObfuscator = BodyObfuscator.Custom()
                    .ObfuscateCustom("cardNumber", obfuscationRule)
                    .Build();

            CheckObfuscatedBodyWithMatches(bodyObfuscator, cardUnObfuscated, cardObfuscatedCustom);
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
            CheckObfuscatedBodyWithNoMatches(noObfuscation);
        }

        [TestCase]
        public void TestObfuscateBodyWithObject()
        {
            CheckObfuscatedBodyWithMatches(noObjectObfuscationUnobfuscated, noObjectObfuscationObfuscated);
        }

        void CheckObfuscatedBodyWithMatches(string body, string expected)
        {
            CheckObfuscatedBodyWithMatches(BodyObfuscator.DefaultObfuscator, body, expected);
        }

        void CheckObfuscatedBodyWithMatches(BodyObfuscator bodyObfuscator, string body, string expected)
        {
            string obfuscatedBody = bodyObfuscator.ObfuscateBody(body);

            Assert.AreEqual(expected, obfuscatedBody);
        }

        void CheckObfuscatedBodyWithNoMatches(string body)
        {
            string obfuscatedBody = BodyObfuscator.DefaultObfuscator.ObfuscateBody(body);

            Assert.AreEqual(body, obfuscatedBody);
        }

        string KeepFirst6AndLast4(string value)
        {
            var chars = value.ToCharArray();
            for (var i = 6; i < chars.Length - 4; i++)
            {
                chars[i] = '*';
            }
            return new string(chars);
        }
    }
}
