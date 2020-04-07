/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        public BankAccountIban BankAccountIban { get; set; } = null;

        public FraudResults FraudResults { get; set; } = null;

        public PaymentProduct3201SpecificOutput PaymentProduct3201SpecificOutput { get; set; } = null;

        public PaymentProduct806SpecificOutput PaymentProduct806SpecificOutput { get; set; } = null;

        public PaymentProduct836SpecificOutput PaymentProduct836SpecificOutput { get; set; } = null;

        public PaymentProduct840SpecificOutput PaymentProduct840SpecificOutput { get; set; } = null;

        public string Token { get; set; } = null;
    }
}
