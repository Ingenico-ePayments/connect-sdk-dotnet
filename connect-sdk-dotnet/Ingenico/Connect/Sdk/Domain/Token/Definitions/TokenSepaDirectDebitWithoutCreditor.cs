/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_TokenSepaDirectDebitWithoutCreditor">TokenSepaDirectDebitWithoutCreditor</a>
    /// </summary>
    public class TokenSepaDirectDebitWithoutCreditor : AbstractToken
    {
        public CustomerTokenWithContactDetails Customer { get; set; } = null;

        public MandateSepaDirectDebitWithoutCreditor Mandate { get; set; } = null;
    }
}
