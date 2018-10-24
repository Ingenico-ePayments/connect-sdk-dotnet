/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class AbstractRedirectPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public int? ExpirationPeriod { get; set; } = null;

        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public bool? RequiresApproval { get; set; } = null;

        public string Token { get; set; } = null;

        public bool? Tokenize { get; set; } = null;
    }
}
