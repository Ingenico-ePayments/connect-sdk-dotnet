/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_TokenNonSepaDirectDebit">TokenNonSepaDirectDebit</a>
    /// </summary>
    public class TokenNonSepaDirectDebit : AbstractToken
    {
        public CustomerToken Customer { get; set; } = null;

        public MandateNonSepaDirectDebit Mandate { get; set; } = null;
    }
}
