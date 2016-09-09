/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_RiskAssessmentBankAccount">RiskAssessmentBankAccount</a>
    /// </summary>
    public class RiskAssessmentBankAccount : RiskAssessment
    {
        public BankAccountBban BankAccountBban { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;
    }
}
