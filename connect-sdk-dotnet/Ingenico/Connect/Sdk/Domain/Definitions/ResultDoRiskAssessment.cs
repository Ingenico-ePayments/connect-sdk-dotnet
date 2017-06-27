/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class ResultDoRiskAssessment
    {
        public string Category { get; set; } = null;

        public string Result { get; set; } = null;

        public RetailDecisionsCCFraudCheckOutput RetaildecisionsCCFraudCheckOutput { get; set; } = null;

        public ValidationBankAccountOutput ValidationBankAccountOutput { get; set; } = null;
    }
}
