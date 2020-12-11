/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class InAuth
    {
        /// <summary>
        /// The type of device used by the customer. Example values: 
        /// <list type="bullet">
        ///   <item><description>SMARTPHONE</description></item>
        ///   <item><description>PERSONAL_COMPUTER</description></item>
        ///   <item><description>TABLET</description></item>
        ///   <item><description>WEARABLE_COMPUTER</description></item>
        ///   <item><description>GAME_CONSOLE</description></item>
        ///   <item><description>SMART_TV</description></item>
        ///   <item><description>PDA</description></item>
        ///   <item><description>OTHER</description></item>
        ///   <item><description>UNKNOWN</description></item>
        /// </list>
        /// </summary>
        public string DeviceCategory { get; set; } = null;

        /// <summary>
        /// This is the device fingerprint value. Based on the amount of data that the device fingerprint collector script was able to collect, this will be a proxy ID for the device used by the customer.
        /// </summary>
        public string DeviceId { get; set; } = null;

        /// <summary>
        /// The score calculated on the basis of Anomalies, Velocity, Location, Integrity, List-Based, and Device Reputation. Range of the score is between 0 and 100. A lower value is better.
        /// </summary>
        public string RiskScore { get; set; } = null;

        /// <summary>
        /// The true IP address as determined by inAuth. This might be different from the IP address that you are seeing on your side due to the proxy piercing technology deployed by inAuth.
        /// </summary>
        public string TrueIpAddress { get; set; } = null;

        /// <summary>
        /// The country of the customer based on the location of the True IP Address determined by inAuth.
        /// </summary>
        public string TrueIpAddressCountry { get; set; } = null;
    }
}
