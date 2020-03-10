/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class NonSepaDirectDebitPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string DateCollect { get; set; } = null;

        public string DirectDebitText { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public NonSepaDirectDebitPaymentProduct705SpecificInput PaymentProduct705SpecificInput { get; set; } = null;

        public NonSepaDirectDebitPaymentProduct730SpecificInput PaymentProduct730SpecificInput { get; set; } = null;

        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public string Token { get; set; } = null;

        public bool? Tokenize { get; set; } = null;
    }
}
