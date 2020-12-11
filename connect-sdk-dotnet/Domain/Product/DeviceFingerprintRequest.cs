/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class DeviceFingerprintRequest
    {
        /// <summary>
        /// You can supply a JavaScript function call that will be called after the device fingerprint data collecting using the provided JavaScript snippet is finished. This will then be added to the snippet that is returned in the property html.
        /// </summary>
        public string CollectorCallback { get; set; } = null;
    }
}
