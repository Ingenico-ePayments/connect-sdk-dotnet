/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class MicrosoftFraudResults
    {
        /// <summary>
        /// Result of the Microsoft Fraud Protection check. This contains the normalized fraud score from a scale of 0 to 100. A higher score indicates an increased risk of fraud.
        /// </summary>
        public int? FraudScore { get; set; } = null;
    }
}
