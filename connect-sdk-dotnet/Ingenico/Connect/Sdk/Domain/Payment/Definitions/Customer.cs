/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_Customer">Customer</a>
    /// </summary>
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
