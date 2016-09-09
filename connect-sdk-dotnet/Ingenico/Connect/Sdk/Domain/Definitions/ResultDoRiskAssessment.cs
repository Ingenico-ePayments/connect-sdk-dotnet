/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_ResultDoRiskAssessment">ResultDoRiskAssessment</a>
    /// </summary>
    public class ResultDoRiskAssessment
    {
        public string Category { get; set; } = null;

        public string Result { get; set; } = null;

        public RetailDecisionsCCFraudCheckOutput RetaildecisionsCCFraudCheckOutput { get; set; } = null;

        public ValidationBankAccountOutput ValidationBankAccountOutput { get; set; } = null;
    }
}
