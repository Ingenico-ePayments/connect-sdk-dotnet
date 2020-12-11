/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ContactDetails : ContactDetailsBase
    {
        /// <summary>
        /// Fax number of the customer
        /// </summary>
        public string FaxNumber { get; set; } = null;

        /// <summary>
        /// International version of the mobile phone number of the customer including the leading + (i.e. +16127779311).
        /// </summary>
        public string MobilePhoneNumber { get; set; } = null;

        /// <summary>
        /// Phone number of the customer
        /// </summary>
        public string PhoneNumber { get; set; } = null;

        /// <summary>
        /// International version of the work phone number of the customer including the leading + (i.e. +31235671500)
        /// </summary>
        public string WorkPhoneNumber { get; set; } = null;
    }
}
