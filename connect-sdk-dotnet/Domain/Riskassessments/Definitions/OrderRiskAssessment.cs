/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    public class OrderRiskAssessment
    {
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; } = null;

        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public CustomerRiskAssessment Customer { get; set; } = null;

        public ShippingRiskAssessment Shipping { get; set; } = null;
    }
}
