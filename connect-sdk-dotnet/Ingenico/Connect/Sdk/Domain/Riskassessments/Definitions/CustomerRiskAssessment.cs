/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    public class CustomerRiskAssessment
    {
        public Address BillingAddress { get; set; } = null;

        public string Locale { get; set; } = null;

        public PersonalInformationRiskAssessment PersonalInformation { get; set; } = null;

        public AddressPersonal ShippingAddress { get; set; } = null;
    }
}
