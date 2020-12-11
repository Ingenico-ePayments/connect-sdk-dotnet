/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Capture.Definitions
{
    public class CaptureStatusOutput
    {
        /// <summary>
        /// Numeric status code of the legacy API. It is returned to ease the migration from the legacy APIs to Ingenico Connect. You should not write new business logic based on this property as it will be deprecated in a future version of the API. The value can also be found in the GlobalCollect Payment Console, in the Ogone BackOffice and in report files.
        /// </summary>
        public int? StatusCode { get; set; } = null;
    }
}
