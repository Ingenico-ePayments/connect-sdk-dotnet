/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class RetailDecisionsCCFraudCheckOutput
    {
        /// <summary>
        /// Provides additional information about the fraud result
        /// </summary>
        public string FraudCode { get; set; } = null;

        /// <summary>
        /// The raw score returned by the Neural check returned by the evaluation of the transaction
        /// </summary>
        public string FraudNeural { get; set; } = null;

        /// <summary>
        /// List of RuleCategoryFlags as setup in the Retail Decisions system that lead to the result
        /// </summary>
        public string FraudRCF { get; set; } = null;
    }
}
