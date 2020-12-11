/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class MobilePaymentData
    {
        /// <summary>
        /// The obfuscated DPAN. Only the last four digits are visible.
        /// </summary>
        public string Dpan { get; set; } = null;

        /// <summary>
        /// Expiry date of the tokenized card
        /// <br />Format: MMYY
        /// </summary>
        public string ExpiryDate { get; set; } = null;
    }
}
