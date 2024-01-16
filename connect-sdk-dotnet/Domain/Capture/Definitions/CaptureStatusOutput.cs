/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using System.Collections.Generic;
using KeyValuePair = Ingenico.Connect.Sdk.Domain.Definitions.KeyValuePair;

namespace Ingenico.Connect.Sdk.Domain.Capture.Definitions
{
    public class CaptureStatusOutput
    {
        /// <summary>
        /// Flag indicating whether a rejected payment may be retried by the merchant without incurring a fee 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsRetriable { get; set; } = null;

        /// <summary>
        /// This is the raw response returned by the acquirer. This property contains unprocessed data directly returned by the acquirer. It's recommended for data analysis only due to its dynamic nature, which may undergo future changes.
        /// </summary>
        public IList<KeyValuePair> ProviderRawOutput { get; set; } = null;

        /// <summary>
        /// Numeric status code of the legacy API. It is returned to ease the migration from the legacy APIs to Worldline Connect. You should not write new business logic based on this property as it will be deprecated in a future version of the API. The value can also be found in the GlobalCollect Payment Console, in the Ogone BackOffice and in report files.
        /// </summary>
        public int? StatusCode { get; set; } = null;
    }
}
