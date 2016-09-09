/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_TokenEWallet">TokenEWallet</a>
    /// </summary>
    public class TokenEWallet : AbstractToken
    {
        public CustomerToken Customer { get; set; } = null;

        public TokenEWalletData Data { get; set; } = null;
    }
}
