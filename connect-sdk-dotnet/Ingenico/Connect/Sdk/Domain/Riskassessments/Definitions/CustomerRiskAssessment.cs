/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CustomerRiskAssessment">CustomerRiskAssessment</a>
    /// </summary>
    public class CustomerRiskAssessment
    {
        public Address BillingAddress { get; set; } = null;

        public string Locale { get; set; } = null;

        public PersonalInformationRiskAssessment PersonalInformation { get; set; } = null;

        public AddressPersonal ShippingAddress { get; set; } = null;
    }
}
