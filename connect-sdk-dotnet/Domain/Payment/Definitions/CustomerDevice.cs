/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CustomerDevice
    {
        public string AcceptHeader { get; set; } = null;

        public BrowserData BrowserData { get; set; } = null;

        public string DefaultFormFill { get; set; } = null;

        public string DeviceFingerprintTransactionId { get; set; } = null;

        public string IpAddress { get; set; } = null;

        public string Locale { get; set; } = null;

        public string TimezoneOffsetUtcMinutes { get; set; } = null;

        public string UserAgent { get; set; } = null;
    }
}
