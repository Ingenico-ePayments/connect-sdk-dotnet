/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Mandates.Definitions
{
    public class MandateResponse
    {
        public string Alias { get; set; } = null;

        public MandateCustomer Customer { get; set; } = null;

        public string CustomerReference { get; set; } = null;

        public string RecurrenceType { get; set; } = null;

        public string Status { get; set; } = null;

        public string UniqueMandateReference { get; set; } = null;
    }
}
