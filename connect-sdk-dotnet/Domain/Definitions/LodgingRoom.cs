/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class LodgingRoom
    {
        /// <summary>
        /// Daily room rate exclusive of any taxes and fees
        /// <br />Note: The currencyCode is presumed to be identical to the order.amountOfMoney.currencyCode.
        /// </summary>
        public string DailyRoomRate { get; set; } = null;

        /// <summary>
        /// Currency for Daily room rate. The code should be in 3 letter ISO format
        /// </summary>
        public string DailyRoomRateCurrencyCode { get; set; } = null;

        /// <summary>
        /// Daily room tax
        /// <br />Note: The currencyCode is presumed to be identical to the order.amountOfMoney.currencyCode.
        /// </summary>
        public string DailyRoomTaxAmount { get; set; } = null;

        /// <summary>
        /// Currency for Daily room tax. The code should be in 3 letter ISO format
        /// </summary>
        public string DailyRoomTaxAmountCurrencyCode { get; set; } = null;

        /// <summary>
        /// Number of nights charged at the rate in the dailyRoomRate property
        /// </summary>
        public int? NumberOfNightsAtRoomRate { get; set; } = null;

        /// <summary>
        /// Location of the room within the facility, e.g. Park or Garden etc.
        /// </summary>
        public string RoomLocation { get; set; } = null;

        /// <summary>
        /// Room number
        /// </summary>
        public string RoomNumber { get; set; } = null;

        /// <summary>
        /// Size of bed, e.g., king, queen, double.
        /// </summary>
        public string TypeOfBed { get; set; } = null;

        /// <summary>
        /// Describes the type of room, e.g., standard, deluxe, suite.
        /// </summary>
        public string TypeOfRoom { get; set; } = null;
    }
}
