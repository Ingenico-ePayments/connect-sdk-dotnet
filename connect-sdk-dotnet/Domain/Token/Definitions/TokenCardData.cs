/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class TokenCardData
    {
        /// <summary>
        /// Object containing the card details (without CVV)
        /// </summary>
        public CardWithoutCvv CardWithoutCvv { get; set; } = null;

        /// <summary>
        /// Date of the first transaction (for ATOS)
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string FirstTransactionDate { get; set; } = null;

        /// <summary>
        /// Reference of the provider (of the first transaction) - used to store the ATOS Transaction Certificate
        /// </summary>
        public string ProviderReference { get; set; } = null;
    }
}
