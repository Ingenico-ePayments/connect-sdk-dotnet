/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class FraugsterResults
    {
        /// <summary>
        /// Result of the Fraugster check Contains the investigation points used during the evaluation
        /// </summary>
        public string FraudInvestigationPoints { get; set; } = null;

        /// <summary>
        /// Result of the Fraugster check Contains the overall Fraud score which is an integer between 0 and 99
        /// </summary>
        public int? FraudScore { get; set; } = null;
    }
}
