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
        /// <summary>
        /// Object containing data related to the account the customer has with you
        /// </summary>
        public CustomerAccountRiskAssessment Account { get; set; } = null;

        /// <summary>
        /// Type of the customer account that is used to place this order. Can have one of the following values: 
        /// <list type="bullet">
        ///   <item><description>none - The account that was used to place the order is a guest account or no account was used at all</description></item>
        ///   <item><description>created - The customer account was created during this transaction</description></item>
        ///   <item><description>existing - The customer account was an already existing account prior to this transaction</description></item>
        /// </list>
        /// </summary>
        public string AccountType { get; set; } = null;

        /// <summary>
        /// Object containing billing address details
        /// </summary>
        public Address BillingAddress { get; set; } = null;

        /// <summary>
        /// Object containing contact details like email address
        /// </summary>
        public ContactDetailsRiskAssessment ContactDetails { get; set; } = null;

        /// <summary>
        /// Object containing information on the device and browser of the customer
        /// </summary>
        public CustomerDeviceRiskAssessment Device { get; set; } = null;

        /// <summary>
        /// Specifies if the customer has a history of online shopping with the merchant 
        /// <list type="bullet">
        ///   <item><description>true - The customer is a known returning customer</description></item>
        ///   <item><description>false - The customer is new/unknown customer</description></item>
        /// </list>
        /// </summary>
        public bool? IsPreviousCustomer { get; set; } = null;

        /// <summary>
        /// The locale that the customer should be addressed in (for 3rd parties). Note that some 3rd party providers only support the languageCode part of the locale, in those cases we will only use part of the locale provided.
        /// </summary>
        public string Locale { get; set; } = null;

        /// <summary>
        /// Object containing personal information like name, date of birth and gender
        /// </summary>
        public PersonalInformationRiskAssessment PersonalInformation { get; set; } = null;

        /// <summary>
        /// Object containing shipping address details
        /// </summary>
        [ObsoleteAttribute("Use Order.shipping.address instead")]
        public AddressPersonal ShippingAddress { get; set; } = null;
    }
}
