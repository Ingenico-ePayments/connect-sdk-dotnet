using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Ingenico.Connect.Sdk.DefaultImpl;

namespace Ingenico.Connect.Sdk
{
    [TestFixture]
    public class FactoryTest
    {
        public static string API_KEY_ID = "someKey";
        public static string SECRET_API_KEY = "someSecret";
        public static IDictionary<string,string> DICT = new Dictionary<string, string> {
                {"connect.api.integrator", "Ingenico"},
                {"connect.api.endpoint.host", "api-sandbox.globalcollect.com" },
                {"connect.api.authorizationType", "v1HMAC"},
                {"connect.api.socketTimeout", "-1"},
                {"connect.api.connectTimeout", "-1"},
                {"connect.api.maxConnections", "100"}
            };

        [TestCase]
        public void TestCreateConfiguration()
        {
            CommunicatorConfiguration configuration = Factory.CreateConfiguration(
                DICT, API_KEY_ID, SECRET_API_KEY);
            Assert.AreEqual(new Uri("https://api-sandbox.globalcollect.com"), configuration.ApiEndpoint);
            Assert.AreEqual(AuthorizationType.V1HMAC, configuration.AuthorizationType);
            Assert.AreEqual(-1, configuration.ConnectTimeout?.TotalMilliseconds);
            Assert.AreEqual(-1, configuration.SocketTimeout?.TotalMilliseconds);
            Assert.AreEqual(100, configuration.MaxConnections);
            Assert.AreEqual(API_KEY_ID, configuration.ApiKeyId);
            Assert.AreEqual(SECRET_API_KEY, configuration.SecretApiKey);
        }

        internal static object GetInstanceField(Type type, object instance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static;
            FieldInfo field = type.GetField(fieldName, bindFlags);
            return field.GetValue(instance);
        }

        [TestCase]
        public void TestCreateCommunicator()
        {
            Communicator communicator = Factory.CreateCommunicator(DICT, API_KEY_ID, SECRET_API_KEY);

            Assert.AreSame(DefaultMarshaller.Instance, communicator.Marshaller);

            Session session = communicator.Session;

            IConnection connection = session.Connection;
            Assert.True(connection is DefaultConnection);
            //DefaultConnectionTest.assertConnection((DefaultConnection) connection, -1, -1, 100, null);

            IAuthenticator authenticator = session.Authenticator;
            Assert.True(authenticator is DefaultAuthenticator);
            Assert.AreEqual(AuthorizationType.V1HMAC, GetInstanceField(typeof(DefaultAuthenticator), authenticator, "_authorizationType"));
            Assert.AreEqual(API_KEY_ID, GetInstanceField(typeof(DefaultAuthenticator), authenticator, "_apiKeyId"));
            Assert.AreEqual(SECRET_API_KEY, GetInstanceField(typeof(DefaultAuthenticator), authenticator, "_secretApiKey"));

            MetaDataProvider metaDataProvider = session.MetaDataProvider;
            Assert.AreEqual(typeof(MetaDataProvider), metaDataProvider.GetType());
            IEnumerable<RequestHeader> requestHeaders = metaDataProvider.ServerMetaDataHeaders;
            Assert.AreEqual(1, requestHeaders.Count());
            RequestHeader requestHeader = requestHeaders.ElementAt(0);
            Assert.AreEqual("X-GCS-ServerMetaInfo", requestHeader.Name);
        }
    }
}
