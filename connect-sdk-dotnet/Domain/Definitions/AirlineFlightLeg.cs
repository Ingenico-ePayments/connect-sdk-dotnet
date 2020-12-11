/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class AirlineFlightLeg
    {
        /// <summary>
        /// Reservation Booking Designator
        /// </summary>
        public string AirlineClass { get; set; } = null;

        /// <summary>
        /// Arrival airport/city code
        /// </summary>
        public string ArrivalAirport { get; set; } = null;

        /// <summary>
        /// The arrival time in the local time zone 
        /// <br />Format: HH:MM
        /// </summary>
        public string ArrivalTime { get; set; } = null;

        /// <summary>
        /// IATA carrier code
        /// </summary>
        public string CarrierCode { get; set; } = null;

        /// <summary>
        /// Identifying number of a ticket issued to a passenger in conjunction with this ticket and that constitutes a single contract of carriage
        /// </summary>
        public string ConjunctionTicket { get; set; } = null;

        /// <summary>
        /// The coupon number associated with this leg of the trip. A ticket can contain several legs of travel, and each leg of travel requires a separate coupon
        /// </summary>
        public string CouponNumber { get; set; } = null;

        /// <summary>
        /// Date of the leg
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string Date { get; set; } = null;

        /// <summary>
        /// The departure time in the local time at the departure airport
        /// <br />Format: HH:MM
        /// </summary>
        public string DepartureTime { get; set; } = null;

        /// <summary>
        /// An endorsement can be an agency-added notation or a mandatory government required notation, such as value-added tax. A restriction is a limitation based on the type of fare, such as a ticket with a 3-day minimum stay
        /// </summary>
        public string EndorsementOrRestriction { get; set; } = null;

        /// <summary>
        /// New ticket number that is issued when a ticket is exchanged
        /// </summary>
        public string ExchangeTicket { get; set; } = null;

        /// <summary>
        /// Fare of this leg
        /// </summary>
        public string Fare { get; set; } = null;

        /// <summary>
        /// Fare Basis/Ticket Designator
        /// </summary>
        public string FareBasis { get; set; } = null;

        /// <summary>
        /// Fee for this leg of the trip
        /// </summary>
        public int? Fee { get; set; } = null;

        /// <summary>
        /// The flight number assigned by the airline carrier with no leading spaces
        /// <br />Should be a numeric string
        /// </summary>
        public string FlightNumber { get; set; } = null;

        /// <summary>
        /// Sequence number of the flight leg
        /// </summary>
        public int? Number { get; set; } = null;

        /// <summary>
        /// Origin airport/city code
        /// </summary>
        public string OriginAirport { get; set; } = null;

        /// <summary>
        /// PassengerClass if this leg
        /// </summary>
        public string PassengerClass { get; set; } = null;

        /// <summary>
        /// ServiceClass of this leg (this property is used for fraud screening on the Ogone Payment Platform). 
        /// <p>Possible values are:</p>
        /// <list type="bullet">
        ///   <item><description>economy</description></item>
        ///   <item><description>premium-economy</description></item>
        ///   <item><description>business</description></item>
        ///   <item><description>first</description></item>
        /// </list>
        /// </summary>
        [ObsoleteAttribute("Use passengerClass instead")]
        public string ServiceClass { get; set; } = null;

        /// <summary>
        /// Possible values are: 
        /// <list type="bullet">
        ///   <item><description>permitted = Stopover permitted</description></item>
        ///   <item><description>non-permitted = Stopover not permitted</description></item>
        /// </list>
        /// </summary>
        public string StopoverCode { get; set; } = null;

        /// <summary>
        /// Taxes for this leg of the trip
        /// </summary>
        public int? Taxes { get; set; } = null;
    }
}
