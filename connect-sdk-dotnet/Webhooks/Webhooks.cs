using Ingenico.Connect.Sdk.DefaultImpl;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// Ingenico ePayments platform factory for several webhooks components.
    /// </summary>
    public static class Webhooks
    {
        /// <summary>
        /// Creates a <see cref="WebhooksHelperBuilder"/> that will use the given <see cref="ISecretKeyStore"/>.
        /// </summary>
        public static WebhooksHelperBuilder CreateHelperBuilder(ISecretKeyStore secretKeyStore)
        {
            return new WebhooksHelperBuilder().WithMarshaller(DefaultMarshaller.Instance).WithSecretKeyStore(secretKeyStore);
        }

        /// <summary>
        /// Creates a <see cref="WebhooksHelper"/> that will use the given <see cref="ISecretKeyStore"/>.
        /// </summary>
        public static WebhooksHelper CreateHelper(ISecretKeyStore secretKeyStore)
        {
            WebhooksHelperBuilder webhooksHelperBuilder = CreateHelperBuilder(secretKeyStore);
            return webhooksHelperBuilder.Build();
        }
    }
}
