/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments
{
    public class RiskAssessmentBankAccount : RiskAssessment
    {
        public BankAccountBban BankAccountBban { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;
    }
}
