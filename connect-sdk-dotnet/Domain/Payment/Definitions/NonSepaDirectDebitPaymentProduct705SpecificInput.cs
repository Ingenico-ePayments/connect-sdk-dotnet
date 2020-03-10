/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class NonSepaDirectDebitPaymentProduct705SpecificInput
    {
        public string AuthorisationId { get; set; } = null;

        public BankAccountBban BankAccountBban { get; set; } = null;

        public string TransactionType { get; set; } = null;
    }
}
