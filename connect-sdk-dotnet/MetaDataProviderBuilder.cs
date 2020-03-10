using System.Collections.Generic;
using System.Linq;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Builder for a <see cref="MetaDataProvider"/> object.
    /// </summary>
    public class MetaDataProviderBuilder
    {
        /// <summary>
        /// Gets or sets the integrator to use.
        /// </summary>
        public string Integrator { get; }

        /// <summary>
        /// Gets or sets the shopping cart extension to use.
        /// </summary>
        public ShoppingCartExtension ShoppingCartExtension { get; set; }

        /// <summary>
        /// Gets or sets the additional request headers.
        /// The following names are prohibited in these additional request headers, because these will be set automatically
        /// as needed:
        /// <list>
        /// <item><description>X-GCS-ServerMetaInfo</description></item>
        /// <item><description>X-GCS-ClientMetaInfo</description></item>
        /// <item><description>X-GCS-Idempotence-Key</description></item>
        /// <item><description>Date</description></item>
        /// <item><description>Content-Type</description></item>
        /// <item><description>Authorization</description></item>
        /// </list>
        /// </summary>
        public IEnumerable<RequestHeader> AdditionalRequestHeaders
        {
            get
            {
                return _additionalRequestHeaders;
            }
            set
            {
                MetaDataProvider.ValidateAdditionalRequestHeaders(value);
                _additionalRequestHeaders = value.ToList();
            }
        }
        IList<RequestHeader> _additionalRequestHeaders = new List<RequestHeader>();

        /// <param name="integrator">The integrator to use.</param>
        public MetaDataProviderBuilder(string integrator)
        {
            Integrator = integrator;
        }

        /// <summary>
        /// Sets the shopping cart extension to use.
        /// </summary>
        /// <returns>This.</returns>
        public MetaDataProviderBuilder WithShoppingCartExtension(ShoppingCartExtension shoppingCartExtension)
        {
            ShoppingCartExtension = shoppingCartExtension;
            return this;
        }

        /// <summary>
        /// Adds an additional request header.
        /// The following names are prohibited in these additional request headers, because these will be set automatically
        /// as needed:
        /// <list>
        /// <item><description>X-GCS-ServerMetaInfo</description></item>
        /// <item><description>X-GCS-ClientMetaInfo</description></item>
        /// <item><description>X-GCS-Idempotence-Key</description></item>
        /// <item><description>Date</description></item>
        /// <item><description>Content-Type</description></item>
        /// <item><description>Authorization</description></item>
        /// </list>
        /// </summary>
        /// <returns>This.</returns>
        public MetaDataProviderBuilder WithAdditionalRequestHeader(RequestHeader additionalRequestHeader)
        {
            MetaDataProvider.ValidateAdditionalRequestHeader(additionalRequestHeader);
            _additionalRequestHeaders.Add(additionalRequestHeader);
            return this;
        }

        /// <summary>
        /// Creates a fully initialized <see cref="MetaDataProvider"/> object.
        /// </summary>
        public MetaDataProvider Build()
        {
            return new MetaDataProvider(this);
        }
    }
}
