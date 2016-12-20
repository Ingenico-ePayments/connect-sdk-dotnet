/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_DecryptedPaymentData">DecryptedPaymentData</a>
    /// </summary>
    public class DecryptedPaymentData
    {
        public string CardholderName { get; set; } = null;

        public string Cryptogram { get; set; } = null;

        public string Dpan { get; set; } = null;

        public int? Eci { get; set; } = null;

        public string ExpiryDate { get; set; } = null;
    }
}
