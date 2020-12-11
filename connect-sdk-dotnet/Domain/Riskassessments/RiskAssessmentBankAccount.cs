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
        /// <summary>
        /// Object containing account holder name and bank account information
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; } = null;

        /// <summary>
        /// Object containing account holder name and IBAN information
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;
    }
}
