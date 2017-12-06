/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class SepaDirectDebitPaymentMethodSpecificInput : AbstractSepaDirectDebitPaymentMethodSpecificInput
    {
        public string DateCollect { get; set; } = null;

        public string DirectDebitText { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public SepaDirectDebitPaymentProduct771SpecificInput PaymentProduct771SpecificInput { get; set; } = null;

        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public string Token { get; set; } = null;

        public bool? Tokenize { get; set; } = null;
    }
}
