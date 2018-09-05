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
        public AddressPersonal Address { get; set; } = null;

        public CompanyInformation CompanyInformation { get; set; } = null;

        public ContactDetailsBase ContactDetails { get; set; } = null;

        public string FiscalNumber { get; set; } = null;
    }
}
