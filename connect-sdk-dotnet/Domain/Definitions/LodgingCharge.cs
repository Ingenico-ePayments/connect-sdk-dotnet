/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class LodgingCharge
    {
        /// <summary>
        /// Amount of additional charges associated with the stay of the guest.
        /// <br />Note: The currencyCode is presumed to be identical to the order.amountOfMoney.currencyCode.
        /// </summary>
        public long? ChargeAmount { get; set; } = null;

        /// <summary>
        /// Currency for Charge amount. The code should be in 3 letter ISO format.
        /// </summary>
        public string ChargeAmountCurrencyCode { get; set; } = null;

        /// <summary>
        /// Type of additional charges associated with the stay of the guest. Allowed values: 
        /// <list type="bullet">
        ///   <item><description>lodging</description></item>
        ///   <item><description>telephone</description></item>
        ///   <item><description>restaurant</description></item>
        ///   <item><description>minibar</description></item>
        ///   <item><description>giftshop</description></item>
        ///   <item><description>laundry</description></item>
        ///   <item><description>transport</description></item>
        ///   <item><description>gratuity</description></item>
        ///   <item><description>conferenceRoom</description></item>
        ///   <item><description>audiovisual</description></item>
        ///   <item><description>banquet</description></item>
        ///   <item><description>internet</description></item>
        ///   <item><description>earlyDeparture</description></item>
        ///   <item><description>roomService</description></item>
        ///   <item><description>loungeBar</description></item>
        ///   <item><description>other</description></item>
        /// </list>
        /// </summary>
        public string ChargeType { get; set; } = null;
    }
}
