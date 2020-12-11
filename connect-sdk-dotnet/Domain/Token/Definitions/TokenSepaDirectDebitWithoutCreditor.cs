/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class TokenSepaDirectDebitWithoutCreditor : AbstractToken
    {
        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public CustomerTokenWithContactDetails Customer { get; set; } = null;

        /// <summary>
        /// Object containing the mandate details
        /// </summary>
        public MandateSepaDirectDebitWithoutCreditor Mandate { get; set; } = null;
    }
}
