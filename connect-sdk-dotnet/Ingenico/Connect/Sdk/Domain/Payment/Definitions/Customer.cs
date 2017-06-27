/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Customer : CustomerBase
    {
        public Address BillingAddress { get; set; } = null;

        public ContactDetails ContactDetails { get; set; } = null;

        public string FiscalNumber { get; set; } = null;

        public string Locale { get; set; } = null;

        public PersonalInformation PersonalInformation { get; set; } = null;

        public AddressPersonal ShippingAddress { get; set; } = null;
    }
}
