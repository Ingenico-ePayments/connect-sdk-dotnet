using NUnit.Framework;
using Ingenico.Connect.Sdk.Merchant.Services;
using Ingenico.Connect.Sdk.Domain.Services;
using Ingenico.Connect.Sdk.DefaultImpl;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Ingenico.Connect.Sdk.Util;

namespace Ingenico.Connect.Sdk.It
{
    public class SDKProxyTest : IntegrationTest
    {
        /// <summary>
        /// Smoke Test for using a proxy configured throught SDK properties.
        /// </summary>
        public async Task Test()
        {
            ConvertAmountParams request = new ConvertAmountParams();
            request.Amount = 123L;
            request.Source = "USD";
            request.Target = "EUR";

            using (Client client = GetClient())
            {
                ServicesClient services = client
                    .Merchant(GetMerchantId())
                    .Services();

                Assert.That(services, Is.TypeOf(typeof(ServicesClient)));
                CommunicatorConfiguration configuration = GetCommunicatorConfiguration();
                Assert.NotNull(configuration.Proxy);
                AssertProxyAndAuthentication(GetConnectionFromService(services), configuration.Proxy);

                ConvertAmount response = await services.ConvertAmount(request);

                Assert.NotNull(response.ConvertedAmount);
            }
        }

        static DefaultConnection GetConnectionFromService(ServicesClient services)
        {
            Communicator communicator = (Communicator)services.GetPrivateField("_communicator");
            Session session = (Session)communicator.GetPrivateField("_session");
            return session.GetPrivateProperty<DefaultConnection>("Connection");
        }

        internal static void AssertProxy(DefaultConnection connection, Proxy proxy)
        {
            HttpClient httpClient = (HttpClient)connection.GetPrivateField("_httpClient");
            HttpClientHandler handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("handler");
            Assert.That(handler.UseProxy, Is.True);
            Assert.That(((WebProxy)handler.Proxy).Address, Is.EqualTo(proxy.Uri));
            Assert.That(((NetworkCredential)handler.Proxy.Credentials), Is.Null);
        }

        internal void AssertProxyAndAuthentication(DefaultConnection connection, Proxy proxy)
        {
            HttpClient httpClient = (HttpClient)connection.GetPrivateField("_httpClient");
            HttpClientHandler handler = (HttpClientHandler)httpClient.GetPrivateField<HttpMessageInvoker>("handler");
            Assert.That(handler.UseProxy, Is.True);
            Assert.That(((WebProxy)handler.Proxy).Address, Is.EqualTo(proxy.Uri));
            Assert.That(((NetworkCredential)handler.Proxy.Credentials), Is.Null);
            Assert.That(((NetworkCredential)handler.Proxy.Credentials).UserName, Is.EqualTo(proxy.Username));
            Assert.That(((NetworkCredential)handler.Proxy.Credentials).Password, Is.EqualTo(proxy.Password));
        }
    }
}
