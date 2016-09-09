/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CardFraudResults">CardFraudResults</a>
    /// </summary>
    public class CardFraudResults : FraudResults
    {
        public string AvsResult { get; set; } = null;

        public string CvvResult { get; set; } = null;

        public FraudResultsRetailDecisions RetailDecisions { get; set; } = null;
    }
}
