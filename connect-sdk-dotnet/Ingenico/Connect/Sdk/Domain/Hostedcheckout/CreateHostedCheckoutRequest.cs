/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CreateHostedCheckoutRequest">CreateHostedCheckoutRequest</a>
    /// </summary>
    public class CreateHostedCheckoutRequest
    {
        public BankTransferPaymentMethodSpecificInputBase BankTransferPaymentMethodSpecificInput { get; set; } = null;

        public CardPaymentMethodSpecificInputBase CardPaymentMethodSpecificInput { get; set; } = null;

        public CashPaymentMethodSpecificInputBase CashPaymentMethodSpecificInput { get; set; } = null;

        public FraudFields FraudFields { get; set; } = null;

        public HostedCheckoutSpecificInput HostedCheckoutSpecificInput { get; set; } = null;

        public Order Order { get; set; } = null;

        public RedirectPaymentMethodSpecificInputBase RedirectPaymentMethodSpecificInput { get; set; } = null;
    }
}
