/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class AirlineFlightLeg
    {
        public string AirlineClass { get; set; } = null;

        public string ArrivalAirport { get; set; } = null;

        public string ArrivalTime { get; set; } = null;

        public string CarrierCode { get; set; } = null;

        public string ConjunctionTicket { get; set; } = null;

        public string CouponNumber { get; set; } = null;

        public string Date { get; set; } = null;

        public string DepartureTime { get; set; } = null;

        public string EndorsementOrRestriction { get; set; } = null;

        public string ExchangeTicket { get; set; } = null;

        public string Fare { get; set; } = null;

        public string FareBasis { get; set; } = null;

        public int? Fee { get; set; } = null;

        public string FlightNumber { get; set; } = null;

        public int? Number { get; set; } = null;

        public string OriginAirport { get; set; } = null;

        public string PassengerClass { get; set; } = null;

        [ObsoleteAttribute("Use passengerClass instead")]
        public string ServiceClass { get; set; } = null;

        public string StopoverCode { get; set; } = null;

        public int? Taxes { get; set; } = null;
    }
}
