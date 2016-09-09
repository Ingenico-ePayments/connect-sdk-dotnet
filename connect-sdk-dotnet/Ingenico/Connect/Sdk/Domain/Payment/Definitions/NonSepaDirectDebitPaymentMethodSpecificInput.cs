/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_NonSepaDirectDebitPaymentMethodSpecificInput">NonSepaDirectDebitPaymentMethodSpecificInput</a>
    /// </summary>
    public class NonSepaDirectDebitPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string DateCollect { get; set; } = null;

        public string DirectDebitText { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public NonSepaDirectDebitPaymentProduct705SpecificInput PaymentProduct705SpecificInput { get; set; } = null;

        public NonSepaDirectDebitPaymentProduct707SpecificInput PaymentProduct707SpecificInput { get; set; } = null;

        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public string Token { get; set; } = null;
    }
}
