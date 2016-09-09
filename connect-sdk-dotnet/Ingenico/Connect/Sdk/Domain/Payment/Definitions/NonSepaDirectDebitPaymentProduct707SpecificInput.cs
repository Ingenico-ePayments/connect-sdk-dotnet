/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_NonSepaDirectDebitPaymentProduct707SpecificInput">NonSepaDirectDebitPaymentProduct707SpecificInput</a>
    /// </summary>
    public class NonSepaDirectDebitPaymentProduct707SpecificInput
    {
        public string AddressLine1 { get; set; } = null;

        public string AddressLine2 { get; set; } = null;

        public string AddressLine3 { get; set; } = null;

        public string AddressLine4 { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;

        public string CustomerBankCity { get; set; } = null;

        public string CustomerBankNumber { get; set; } = null;

        public string CustomerBankStreet { get; set; } = null;

        public string CustomerBankZip { get; set; } = null;
    }
}
