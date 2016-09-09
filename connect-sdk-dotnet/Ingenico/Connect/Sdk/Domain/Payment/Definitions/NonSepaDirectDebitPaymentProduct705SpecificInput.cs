/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_NonSepaDirectDebitPaymentProduct705SpecificInput">NonSepaDirectDebitPaymentProduct705SpecificInput</a>
    /// </summary>
    public class NonSepaDirectDebitPaymentProduct705SpecificInput
    {
        public string AuthorisationId { get; set; } = null;

        public BankAccountBban BankAccountBban { get; set; } = null;

        public string TransactionType { get; set; } = null;
    }
}
