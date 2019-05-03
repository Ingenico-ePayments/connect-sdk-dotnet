/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Shipping
    {
        public AddressPersonal Address { get; set; } = null;

        public string AddressIndicator { get; set; } = null;

        public string Comments { get; set; } = null;

        public string EmailAddress { get; set; } = null;

        public string FirstUsageDate { get; set; } = null;

        public bool? IsFirstUsage { get; set; } = null;

        public string TrackingNumber { get; set; } = null;

        public string Type { get; set; } = null;
    }
}
