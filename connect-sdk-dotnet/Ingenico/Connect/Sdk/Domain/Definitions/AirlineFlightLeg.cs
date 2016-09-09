/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_AirlineFlightLeg">AirlineFlightLeg</a>
    /// </summary>
    public class AirlineFlightLeg
    {
        public string AirlineClass { get; set; } = null;

        public string ArrivalAirport { get; set; } = null;

        public string CarrierCode { get; set; } = null;

        public string Date { get; set; } = null;

        public string DepartureTime { get; set; } = null;

        public string Fare { get; set; } = null;

        public string FareBasis { get; set; } = null;

        public string FlightNumber { get; set; } = null;

        public int? Number { get; set; } = null;

        public string OriginAirport { get; set; } = null;

        public string StopoverCode { get; set; } = null;
    }
}
