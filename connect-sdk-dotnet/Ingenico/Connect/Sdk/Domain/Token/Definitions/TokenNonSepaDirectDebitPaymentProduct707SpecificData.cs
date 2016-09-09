/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_TokenNonSepaDirectDebitPaymentProduct707SpecificData">TokenNonSepaDirectDebitPaymentProduct707SpecificData</a>
    /// </summary>
    public class TokenNonSepaDirectDebitPaymentProduct707SpecificData
    {
        public string AddressLine1 { get; set; } = null;

        public string AddressLine2 { get; set; } = null;

        public string AddressLine3 { get; set; } = null;

        public string AddressLine4 { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;
    }
}
