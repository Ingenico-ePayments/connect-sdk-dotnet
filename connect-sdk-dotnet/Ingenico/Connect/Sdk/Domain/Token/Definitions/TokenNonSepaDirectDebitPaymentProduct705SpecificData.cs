/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_TokenNonSepaDirectDebitPaymentProduct705SpecificData">TokenNonSepaDirectDebitPaymentProduct705SpecificData</a>
    /// </summary>
    public class TokenNonSepaDirectDebitPaymentProduct705SpecificData
    {
        public string AuthorisationId { get; set; } = null;

        public BankAccountBban BankAccountBban { get; set; } = null;
    }
}
