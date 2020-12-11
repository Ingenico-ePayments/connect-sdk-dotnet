/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Mandates.Definitions
{
    public class MandateCustomer
    {
        /// <summary>
        /// Object containing IBAN information
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;

        /// <summary>
        /// Name of company, as a customer
        /// </summary>
        public string CompanyName { get; set; } = null;

        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        public MandateContactDetails ContactDetails { get; set; } = null;

        /// <summary>
        /// Object containing billing address details
        /// </summary>
        public MandateAddress MandateAddress { get; set; } = null;

        /// <summary>
        /// Object containing personal information of the customer
        /// </summary>
        public MandatePersonalInformation PersonalInformation { get; set; } = null;
    }
}
