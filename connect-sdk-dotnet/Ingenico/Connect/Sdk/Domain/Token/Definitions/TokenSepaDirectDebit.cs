/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_TokenSepaDirectDebit">TokenSepaDirectDebit</a>
    /// </summary>
    public class TokenSepaDirectDebit : AbstractToken
    {
        public CustomerTokenWithContactDetails Customer { get; set; } = null;

        public MandateSepaDirectDebit Mandate { get; set; } = null;
    }
}
