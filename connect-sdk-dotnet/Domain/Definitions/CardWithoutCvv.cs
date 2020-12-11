/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class CardWithoutCvv : CardEssentials
    {
        /// <summary>
        /// Card holder's name on the card
        /// </summary>
        public string CardholderName { get; set; } = null;

        /// <summary>
        /// Issue number on the card (if applicable)
        /// </summary>
        public string IssueNumber { get; set; } = null;
    }
}
