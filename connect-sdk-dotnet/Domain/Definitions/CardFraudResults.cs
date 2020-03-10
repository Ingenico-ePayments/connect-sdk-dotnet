/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class CardFraudResults : FraudResults
    {
        public string AvsResult { get; set; } = null;

        public string CvvResult { get; set; } = null;

        public FraugsterResults Fraugster { get; set; } = null;

        public FraudResultsRetailDecisions RetailDecisions { get; set; } = null;
    }
}
