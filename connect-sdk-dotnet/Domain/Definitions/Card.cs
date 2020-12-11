/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class Card : CardWithoutCvv
    {
        /// <summary>
        /// Card Verification Value, a 3 or 4 digit code used as an additional security feature for card not present transactions.
        /// </summary>
        public string Cvv { get; set; } = null;
    }
}
