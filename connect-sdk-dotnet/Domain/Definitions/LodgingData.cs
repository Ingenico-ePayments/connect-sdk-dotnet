/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class LodgingData
    {
        /// <summary>
        /// Object that holds lodging related charges
        /// </summary>
        public IList<LodgingCharge> Charges { get; set; } = null;

        /// <summary>
        /// The date the guest checks into (or plans to check in to) the facility. 
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string CheckInDate { get; set; } = null;

        /// <summary>
        /// The date the guest checks out of (or plans to check out of) the facility. 
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string CheckOutDate { get; set; } = null;

        /// <summary>
        /// The Lodging Folio Number assigned to the itemized statement of charges and credits associated with this lodging stay, which can be any combination of characters and numerals defined by the Merchant or authorized Third Party Processor.
        /// </summary>
        public string FolioNumber { get; set; } = null;

        /// <summary>
        /// Indicates whether the room reservation is confirmed. 
        /// <list type="bullet">
        ///   <item><description>true - The room reservation is confirmed</description></item>
        ///   <item><description>false - The room reservation is not confirmed</description></item>
        /// </list>
        /// </summary>
        public bool? IsConfirmedReservation { get; set; } = null;

        /// <summary>
        /// Defines whether or not the facility conforms to the requirements of the Hotel and Motel Fire Safety Act of 1990, or similar legislation. 
        /// <list type="bullet">
        ///   <item><description>true - The facility conform to the requirements</description></item>
        ///   <item><description>false - The facility doesn't conform to the requirements</description></item>
        /// </list>
        /// </summary>
        public bool? IsFacilityFireSafetyConform { get; set; } = null;

        /// <summary>
        /// Indicate if this the customer is a no show case. In such case, the lodging property can charge a no show fee. 
        /// <list type="bullet">
        ///   <item><description>true - The customer is a no show</description></item>
        ///   <item><description>false - Not applicable</description></item>
        /// </list>
        /// </summary>
        public bool? IsNoShow { get; set; } = null;

        /// <summary>
        /// Indicated the preference of the customer for a smoking or non-smoking room. 
        /// <list type="bullet">
        ///   <item><description>true - A smoking room is preferred</description></item>
        ///   <item><description>false - A non-smoking room is preferred</description></item>
        /// </list>
        /// </summary>
        public bool? IsPreferenceSmokingRoom { get; set; } = null;

        /// <summary>
        /// The total number of adult guests staying (or planning to stay) at the facility (i.e., all booked rooms)
        /// </summary>
        public int? NumberOfAdults { get; set; } = null;

        /// <summary>
        /// The number of nights for the lodging stay
        /// </summary>
        public int? NumberOfNights { get; set; } = null;

        /// <summary>
        /// The number of rooms rented for the lodging stay
        /// </summary>
        public int? NumberOfRooms { get; set; } = null;

        /// <summary>
        /// Code that corresponds to the category of lodging charges detailed in this message. Allowed values: 
        /// <list type="bullet">
        ///   <item><description>lodging - (Default) Submitted charges are for lodging</description></item>
        ///   <item><description>noShow - Submitted charges are for the failure of the guest(s) to check in for reserved a room</description></item>
        ///   <item><description>advancedDeposit - Submitted charges are for an Advanced Deposit to reserve one or more rooms</description></item>
        /// </list>If no value is submitted the default value lodging is used.
        /// </summary>
        public string ProgramCode { get; set; } = null;

        /// <summary>
        /// The international customer service phone number of the facility
        /// </summary>
        public string PropertyCustomerServicePhoneNumber { get; set; } = null;

        /// <summary>
        /// The local phone number of the facility in an international phone number format
        /// </summary>
        public string PropertyPhoneNumber { get; set; } = null;

        /// <summary>
        /// Name of the person or business entity charged for the reservation and/or lodging stay
        /// </summary>
        public string RenterName { get; set; } = null;

        /// <summary>
        /// Object that holds lodging related room data
        /// </summary>
        public IList<LodgingRoom> Rooms { get; set; } = null;
    }
}
