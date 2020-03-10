/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class DecryptedPaymentData
    {
        public string CardholderName { get; set; } = null;

        public string Cryptogram { get; set; } = null;

        public string Dpan { get; set; } = null;

        public int? Eci { get; set; } = null;

        public string ExpiryDate { get; set; } = null;

        public string Pan { get; set; } = null;

        public string PaymentMethod { get; set; } = null;
    }
}
