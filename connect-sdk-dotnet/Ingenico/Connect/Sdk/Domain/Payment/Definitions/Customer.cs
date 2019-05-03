/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Customer : CustomerBase
    {
        public CustomerAccount Account { get; set; } = null;

        public string AccountType { get; set; } = null;

        public Address BillingAddress { get; set; } = null;

        public ContactDetails ContactDetails { get; set; } = null;

        public CustomerDevice Device { get; set; } = null;

        public string FiscalNumber { get; set; } = null;

        public bool? IsPreviousCustomer { get; set; } = null;

        public string Locale { get; set; } = null;

        public PersonalInformation PersonalInformation { get; set; } = null;

        [ObsoleteAttribute("Use Order.shipping.address instead")]
        public AddressPersonal ShippingAddress { get; set; } = null;
    }
}
