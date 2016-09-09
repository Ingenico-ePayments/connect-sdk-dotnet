/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_OrderRiskAssessment">OrderRiskAssessment</a>
    /// </summary>
    public class OrderRiskAssessment
    {
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; } = null;

        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public CustomerRiskAssessment Customer { get; set; } = null;
    }
}
