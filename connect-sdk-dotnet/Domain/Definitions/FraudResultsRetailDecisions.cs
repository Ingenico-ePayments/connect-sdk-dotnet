/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class FraudResultsRetailDecisions
    {
        /// <summary>
        /// Result of the fraud service. Provides additional information about the fraud result
        /// </summary>
        public string FraudCode { get; set; } = null;

        /// <summary>
        /// Returns the raw score of the neural
        /// </summary>
        public string FraudNeural { get; set; } = null;

        /// <summary>
        /// Result of the fraud service Represent sets of fraud rules returned during the evaluation of the transaction
        /// </summary>
        public string FraudRCF { get; set; } = null;
    }
}
