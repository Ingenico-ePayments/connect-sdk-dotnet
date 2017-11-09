/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Mandates.Definitions
{
    public class CreateMandateBase
    {
        public MandateCustomer Customer { get; set; } = null;

        public string CustomerReference { get; set; } = null;

        public string Language { get; set; } = null;

        public string RecurrenceType { get; set; } = null;

        public string ReturnUrl { get; set; } = null;

        public string SignatureType { get; set; } = null;
    }
}
