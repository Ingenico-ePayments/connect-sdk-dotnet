/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class AirlineData
    {
        /// <summary>
        /// Numeric code identifying the agent
        /// </summary>
        public string AgentNumericCode { get; set; } = null;

        /// <summary>
        /// Airline numeric code
        /// </summary>
        public string Code { get; set; } = null;

        /// <summary>
        /// Date of the Flight
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string FlightDate { get; set; } = null;

        /// <summary>
        /// Object that holds the data on the individual legs of the ticket
        /// </summary>
        public IList<AirlineFlightLeg> FlightLegs { get; set; } = null;

        /// <summary>
        /// Airline tracing number
        /// </summary>
        public string InvoiceNumber { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true = The ticket is an E-Ticket</description></item>
        ///   <item><description>false = the ticket is not an E-Ticket</description></item>
        /// </list>
        /// </summary>
        public bool? IsETicket { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true = a registered known customer</description></item>
        ///   <item><description>false = unknown customer</description></item>
        /// </list>
        /// </summary>
        [ObsoleteAttribute("Use Order.customer.accountType instead")]
        public bool? IsRegisteredCustomer { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - Restricted, the ticket is non-refundable</description></item>
        ///   <item><description>false - No restrictions, the ticket is (partially) refundable</description></item>
        /// </list>
        /// </summary>
        public bool? IsRestrictedTicket { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - The payer is the ticket holder</description></item>
        ///   <item><description>false - The payer is not the ticket holder</description></item>
        /// </list>
        /// </summary>
        public bool? IsThirdParty { get; set; } = null;

        /// <summary>
        /// This is the date of issue recorded in the airline system In a case of multiple issuances of the same ticket to a cardholder, you should use the last ticket date.
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string IssueDate { get; set; } = null;

        /// <summary>
        /// Your ID of the customer in the context of the airline data
        /// </summary>
        public string MerchantCustomerId { get; set; } = null;

        /// <summary>
        /// Name of the airline
        /// </summary>
        public string Name { get; set; } = null;

        /// <summary>
        /// Name of passenger
        /// </summary>
        public string PassengerName { get; set; } = null;

        /// <summary>
        /// Object that holds the data on the individual passengers (this object is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public IList<AirlinePassenger> Passengers { get; set; } = null;

        /// <summary>
        /// Place of issue
        /// <br />For sales in the US the last two characters (pos 14-15) must be the US state code.
        /// </summary>
        public string PlaceOfIssue { get; set; } = null;

        /// <summary>
        /// Passenger name record
        /// </summary>
        public string Pnr { get; set; } = null;

        /// <summary>
        /// IATA point of sale name
        /// </summary>
        public string PointOfSale { get; set; } = null;

        /// <summary>
        /// city code of the point of sale
        /// </summary>
        public string PosCityCode { get; set; } = null;

        /// <summary>
        /// Possible values: 
        /// <list type="bullet">
        ///   <item><description>e-ticket</description></item>
        ///   <item><description>city-ticket-office</description></item>
        ///   <item><description>airport-ticket-office</description></item>
        ///   <item><description>ticket-by-mail</description></item>
        ///   <item><description>ticket-on-departure</description></item>
        /// </list>
        /// </summary>
        public string TicketDeliveryMethod { get; set; } = null;

        /// <summary>
        /// The ticket or document number contains:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>Airline code: 3-digit airline code number</description></item>
        ///   <item><description>Form code: A maximum of 3 digits indicating the type of document, the source of issue and the number of coupons it contains</description></item>
        ///   <item><description>Serial number: A maximum of 8 digits allocated on a sequential basis, provided that the total number of digits allocated to the form code and serial number shall not exceed ten</description></item>
        ///   <item><description>TICKETNUMBER can be replaced with PNR if the ticket number is unavailable</description></item>
        /// </list>
        /// </summary>
        public string TicketNumber { get; set; } = null;

        /// <summary>
        /// Total fare for all legs on the ticket, excluding taxes and fees. If multiple tickets are purchased, this is the total fare for all tickets
        /// </summary>
        public int? TotalFare { get; set; } = null;

        /// <summary>
        /// Total fee for all legs on the ticket. If multiple tickets are purchased, this is the total fee for all tickets
        /// </summary>
        public int? TotalFee { get; set; } = null;

        /// <summary>
        /// Total taxes for all legs on the ticket. If multiple tickets are purchased, this is the total taxes for all tickets
        /// </summary>
        public int? TotalTaxes { get; set; } = null;

        /// <summary>
        /// Name of the travel agency issuing the ticket. For direct airline integration, leave this property blank
        /// </summary>
        public string TravelAgencyName { get; set; } = null;
    }
}
