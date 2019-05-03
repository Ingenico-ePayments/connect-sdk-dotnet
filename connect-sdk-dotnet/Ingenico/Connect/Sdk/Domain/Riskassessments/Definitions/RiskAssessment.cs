/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    public class RiskAssessment
    {
        public FraudFields FraudFields { get; set; } = null;

        public MerchantRiskAssessment Merchant { get; set; } = null;

        public OrderRiskAssessment Order { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;
    }
}
