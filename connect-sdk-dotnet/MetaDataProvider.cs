using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Ingenico.Connect.Sdk.DefaultImpl;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Provides meta info about the server. Thread-safe.
    /// </summary>
    public class MetaDataProvider
    {
        public MetaDataProvider(MetaDataProviderBuilder builder)
            : this(builder.Integrator, builder.ShoppingCartExtension, builder.AdditionalRequestHeaders)
        {

        }

        public MetaDataProvider(string integrator) : this(integrator, null, null)
        {

        }

        public static void ValidateAdditionalRequestHeader(RequestHeader additionalRequestHeader)
        {
            if (ProhibitedHeaders.Contains(additionalRequestHeader.Name))
            {
                throw new ArgumentException("request header not allowed: " + additionalRequestHeader);
            }
        }

        /// <summary>
        /// Gets the server related headers containing the metadata to be associated with the request (if any).
        /// This will always contain at least an automatically generated header <code>X-GCS-ServerMetaInfo</code>.
        /// </summary>
        public IEnumerable<RequestHeader> ServerMetaDataHeaders { get; }

        public static readonly IEnumerable<string> ProhibitedHeaders
            = new ReadOnlyCollection<string>(new List<string>
        {
            SERVER_META_INFO_HEADER,
            "X-GCS-Idempotence-Key",
            "Date",
            "Content-Type",
            "Authorization"
        });

        MetaDataProvider(string integrator, ShoppingCartExtension shoppingCartExtension, IEnumerable<RequestHeader> additionalRequestHeaders)
        {
            ValidateAdditionalRequestHeaders(additionalRequestHeaders);

            ServerMetaInfo serverMetaInfo = new ServerMetaInfo()
            {
                PlatformIdentifier = PlatformIdentifier,
                SdkIdentifier = SdkIdentifier,
                SdkCreator = "Ingenico",
                Integrator = integrator,
                ShoppingCartExtension = shoppingCartExtension
            };

            string serverMetaInfoString = DefaultMarshaller.Instance.Marshal(serverMetaInfo);
            RequestHeader serverMetaInfoHeader = new RequestHeader(SERVER_META_INFO_HEADER, serverMetaInfoString.ToBase64String());

            ServerMetaDataHeaders = new List<RequestHeader> { serverMetaInfoHeader }
                .Concat(additionalRequestHeaders ?? Enumerable.Empty<RequestHeader>()); ;
        }

        internal class ServerMetaInfo
        {
            public string PlatformIdentifier { get; set; }

            public string SdkIdentifier { get; set; }

            public string SdkCreator { get; set; }

            public string Integrator { get; set; }

            public ShoppingCartExtension ShoppingCartExtension { get; set; }
        }

        internal string SdkIdentifier => "DotnetServerSDK/v" + SDK_VERSION;

        internal string PlatformIdentifier
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Environment.OSVersion.Platform);
                sb.Append("/");
                sb.Append(Environment.OSVersion.Version);
                sb.Append(" .NET/");
                sb.Append(Environment.Version);
                return sb.ToString();
            }
        }

        const string SDK_VERSION = "3.9.1";

        const string SERVER_META_INFO_HEADER = "X-GCS-ServerMetaInfo";

        internal static void ValidateAdditionalRequestHeaders(IEnumerable<RequestHeader> additionalRequestHeaders)
        {
            if (additionalRequestHeaders != null)
            {
                foreach (RequestHeader additionalRequestHeader in additionalRequestHeaders)
                {
                    ValidateAdditionalRequestHeader(additionalRequestHeader);
                }
            }
        }
    }
}
