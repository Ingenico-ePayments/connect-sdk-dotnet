/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    public class CustomerRiskAssessment
    {
        public CustomerAccountRiskAssessment Account { get; set; } = null;

        public string AccountType { get; set; } = null;

        public Address BillingAddress { get; set; } = null;

        public ContactDetailsRiskAssessment ContactDetails { get; set; } = null;

        public CustomerDeviceRiskAssessment Device { get; set; } = null;

        public bool? IsPreviousCustomer { get; set; } = null;

        public string Locale { get; set; } = null;

        public PersonalInformationRiskAssessment PersonalInformation { get; set; } = null;

        [ObsoleteAttribute("Use Order.shipping.address instead")]
        public AddressPersonal ShippingAddress { get; set; } = null;
    }
}
