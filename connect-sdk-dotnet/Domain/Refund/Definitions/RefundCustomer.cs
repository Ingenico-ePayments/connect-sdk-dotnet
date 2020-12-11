/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund.Definitions
{
    public class RefundCustomer
    {
        /// <summary>
        /// Object containing address details
        /// </summary>
        public AddressPersonal Address { get; set; } = null;

        /// <summary>
        /// Object containing company information
        /// </summary>
        public CompanyInformation CompanyInformation { get; set; } = null;

        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        public ContactDetailsBase ContactDetails { get; set; } = null;

        /// <summary>
        /// Fiscal registration number of the customer (CPF) with a length of 11 or the tax registration number of the company for a business customer (CNPJ) with a length of 14.
        /// </summary>
        public string FiscalNumber { get; set; } = null;
    }
}
