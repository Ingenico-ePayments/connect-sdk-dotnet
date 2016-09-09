/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_TokenCardData">TokenCardData</a>
    /// </summary>
    public class TokenCardData
    {
        public CardWithoutCvv CardWithoutCvv { get; set; } = null;

        public string FirstTransactionDate { get; set; } = null;

        public string ProviderReference { get; set; } = null;
    }
}
