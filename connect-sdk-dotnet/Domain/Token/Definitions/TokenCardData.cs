/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class TokenCardData
    {
        public CardWithoutCvv CardWithoutCvv { get; set; } = null;

        public string FirstTransactionDate { get; set; } = null;

        public string ProviderReference { get; set; } = null;
    }
}
