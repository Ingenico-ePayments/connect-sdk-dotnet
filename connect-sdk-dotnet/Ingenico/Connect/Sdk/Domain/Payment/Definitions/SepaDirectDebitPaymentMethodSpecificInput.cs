/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_SepaDirectDebitPaymentMethodSpecificInput">SepaDirectDebitPaymentMethodSpecificInput</a>
    /// </summary>
    public class SepaDirectDebitPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string DateCollect { get; set; } = null;

        public string DirectDebitText { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public string Token { get; set; } = null;

        public bool? Tokenize { get; set; } = null;
    }
}
