/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_RedirectPaymentMethodSpecificOutput">RedirectPaymentMethodSpecificOutput</a>
    /// </summary>
    public class RedirectPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        public BankAccountIban BankAccountIban { get; set; } = null;

        public PaymentProduct836SpecificOutput PaymentProduct836SpecificOutput { get; set; } = null;

        public PaymentProduct840SpecificOutput PaymentProduct840SpecificOutput { get; set; } = null;
    }
}
