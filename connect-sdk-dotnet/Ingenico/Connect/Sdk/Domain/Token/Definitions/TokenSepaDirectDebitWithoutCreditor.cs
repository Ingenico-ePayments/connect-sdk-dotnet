/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class TokenSepaDirectDebitWithoutCreditor : AbstractToken
    {
        public CustomerTokenWithContactDetails Customer { get; set; } = null;

        public MandateSepaDirectDebitWithoutCreditor Mandate { get; set; } = null;
    }
}
