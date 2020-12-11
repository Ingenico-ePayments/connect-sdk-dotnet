/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Shipping
    {
        /// <summary>
        /// Object containing address information
        /// </summary>
        public AddressPersonal Address { get; set; } = null;

        /// <summary>
        /// Indicates shipping method chosen for the transaction. Possible values: 
        /// <list type="bullet">
        ///   <item><description>same-as-billing = the shipping address is the same as the billing address</description></item>
        ///   <item><description>another-verified-address-on-file-with-merchant = the address used for shipping is another verified address of the customer that is on file with you</description></item>
        ///   <item><description>different-than-billing = shipping address is different from the billing address</description></item>
        ///   <item><description>ship-to-store = goods are shipped to a store (shipping address = store address)</description></item>
        ///   <item><description>digital-goods = electronic delivery of digital goods</description></item>
        ///   <item><description>travel-and-event-tickets-not-shipped = travel and/or event tickets that are not shipped</description></item>
        ///   <item><description>other = other means of delivery</description></item>
        /// </list>
        /// </summary>
        public string AddressIndicator { get; set; } = null;

        /// <summary>
        /// Comments included during shipping
        /// </summary>
        public string Comments { get; set; } = null;

        /// <summary>
        /// Email address linked to the shipping
        /// </summary>
        public string EmailAddress { get; set; } = null;

        /// <summary>
        /// Date (YYYYMMDD) when the shipping details for this transaction were first used.
        /// </summary>
        public string FirstUsageDate { get; set; } = null;

        /// <summary>
        /// Indicator if this shipping address is used for the first time to ship an order 
        /// <p>true = the shipping details are used for the first time with this transaction</p>
        /// <p>false = the shipping details have been used for other transactions in the past</p>
        /// </summary>
        public bool? IsFirstUsage { get; set; } = null;

        /// <summary>
        /// Shipment tracking number
        /// </summary>
        public string TrackingNumber { get; set; } = null;

        /// <summary>
        /// Indicates the merchandise delivery timeframe. Possible values: 
        /// <list type="bullet">
        ///   <item><description>electronic = For electronic delivery (services or digital goods</description></item>
        ///   <item><description>same-day = For same day deliveries</description></item>
        ///   <item><description>overnight = For overnight deliveries</description></item>
        ///   <item><description>2-day-or-more = For two day or more delivery time</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; } = null;
    }
}
