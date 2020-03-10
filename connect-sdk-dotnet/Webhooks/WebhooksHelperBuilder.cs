using System;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// Builder for a <see cref="WebhooksHelper"/> object.
    /// </summary>
    public class WebhooksHelperBuilder
    {
        IMarshaller Marshaller {get; set;}
        ISecretKeyStore SecretKeyStore { get; set;}

        /// <summary>
        /// Sets the <see cref="IMarshaller"/> to use.
        /// </summary>
        public WebhooksHelperBuilder WithMarshaller(IMarshaller marshaller) {
            this.Marshaller = marshaller;
            return this;
        }

        /// <summary>
        /// Sets the <see cref="ISecretKeyStore"/> to use.
        /// </summary>
        public WebhooksHelperBuilder WithSecretKeyStore(ISecretKeyStore secretKeyStore) {
            this.SecretKeyStore = secretKeyStore;
            return this;
        }

        /// <summary>
        /// Creates a fully initialized <see cref="WebhooksHelper"/> object.
        /// </summary>
        /// <exception cref="ArgumentNullException"> If Not all required arguments are set.</exception>
        public WebhooksHelper Build()
        {
            return new WebhooksHelper(Marshaller, SecretKeyStore);
        }
    }
}
