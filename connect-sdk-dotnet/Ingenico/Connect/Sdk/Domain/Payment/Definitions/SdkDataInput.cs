/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class SdkDataInput
    {
        public string DeviceInfo { get; set; } = null;

        public DeviceRenderOptions DeviceRenderOptions { get; set; } = null;

        public string SdkAppId { get; set; } = null;

        public string SdkEncryptedData { get; set; } = null;

        public string SdkEphemeralPublicKey { get; set; } = null;

        public string SdkMaxTimeout { get; set; } = null;

        public string SdkReferenceNumber { get; set; } = null;

        public string SdkTransactionId { get; set; } = null;
    }
}
