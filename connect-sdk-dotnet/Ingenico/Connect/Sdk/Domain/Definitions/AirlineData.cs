/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class AirlineData
    {
        public string AgentNumericCode { get; set; } = null;

        public string Code { get; set; } = null;

        public string FlightDate { get; set; } = null;

        public IList<AirlineFlightLeg> FlightLegs { get; set; } = null;

        public string InvoiceNumber { get; set; } = null;

        public bool? IsETicket { get; set; } = null;

        public bool? IsRegisteredCustomer { get; set; } = null;

        public bool? IsRestrictedTicket { get; set; } = null;

        public bool? IsThirdParty { get; set; } = null;

        public string IssueDate { get; set; } = null;

        public string MerchantCustomerId { get; set; } = null;

        public string Name { get; set; } = null;

        public string PassengerName { get; set; } = null;

        public IList<AirlinePassenger> Passengers { get; set; } = null;

        public string PlaceOfIssue { get; set; } = null;

        public string Pnr { get; set; } = null;

        public string PointOfSale { get; set; } = null;

        public string PosCityCode { get; set; } = null;

        public string TicketDeliveryMethod { get; set; } = null;

        public string TicketNumber { get; set; } = null;
    }
}
