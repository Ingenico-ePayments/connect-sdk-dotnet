using NUnit.Framework;

namespace Ingenico.Connect.Sdk.Logging
{
    [TestFixture]
    public class HeaderObfuscatorTest
    {
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

        [TestCase]
        public void TestObfuscateCustomHeader()
        {
            HeaderObfuscator headerObfuscator = HeaderObfuscator.Custom()
                    .ObfuscateAll("content-type")
                    .Build();

            CheckObfuscateHeaderWithMatch(headerObfuscator, "Authorization", "Basic QWxhZGRpbjpPcGVuU2VzYW1l", "********");
            CheckObfuscateHeaderWithMatch(headerObfuscator, "authorization", "Basic QWxhZGRpbjpPcGVuU2VzYW1l", "********");
            CheckObfuscateHeaderWithMatch(headerObfuscator, "AUTHORIZATION", "Basic QWxhZGRpbjpPcGVuU2VzYW1l", "********");

            CheckObfuscateHeaderWithMatch(headerObfuscator, "X-GCS-Authentication-Token", "foobar", "********");
            CheckObfuscateHeaderWithMatch(headerObfuscator, "x-gcs-authentication-token", "foobar", "********");
            CheckObfuscateHeaderWithMatch(headerObfuscator, "X-GCS-AUTHENTICATION-TOKEN", "foobar", "********");

            CheckObfuscateHeaderWithMatch(headerObfuscator, "X-GCS-CallerPassword", "foobar", "********");
            CheckObfuscateHeaderWithMatch(headerObfuscator, "x-gcs-callerpassword", "foobar", "********");
            CheckObfuscateHeaderWithMatch(headerObfuscator, "X-GCS-CALLERPASSWORD", "foobar", "********");

            CheckObfuscateHeaderWithMatch(headerObfuscator, "Content-Type", "application/json", "****************");
            CheckObfuscateHeaderWithMatch(headerObfuscator, "content-type", "application/json", "****************");
            CheckObfuscateHeaderWithMatch(headerObfuscator, "CONTENT-TYPE", "application/json", "****************");
        }

        void CheckObfuscateHeaderWithMatch(string name, string originalValue, string expectedObfuscatedValue)
        {
            string obfuscatedValue = HeaderObfuscator.DefaultObfuscator.ObfuscateHeader(name, originalValue);

            Assert.AreEqual(expectedObfuscatedValue, obfuscatedValue);
        }

        void CheckObfuscateHeaderWithMatch(HeaderObfuscator headerObfuscator, string name, string originalValue, string expectedObfuscatedValue)
        {
            string obfuscatedValue = headerObfuscator.ObfuscateHeader(name, originalValue);

            Assert.AreEqual(expectedObfuscatedValue, obfuscatedValue);
        }

        void CheckObfuscateHeaderWithNoMatch(string name, string originalValue)
        {
            string obfuscatedValue = HeaderObfuscator.DefaultObfuscator.ObfuscateHeader(name, originalValue);

            Assert.AreEqual(originalValue, obfuscatedValue);
        }
    }
}
