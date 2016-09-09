/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_RiskAssessment">RiskAssessment</a>
    /// </summary>
    public class RiskAssessment
    {
        public FraudFields FraudFields { get; set; } = null;

        public OrderRiskAssessment Order { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;
    }
}
