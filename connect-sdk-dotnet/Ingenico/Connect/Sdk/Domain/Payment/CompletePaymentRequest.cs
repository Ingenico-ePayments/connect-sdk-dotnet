/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class CompletePaymentRequest
    {
        public CompletePaymentCardPaymentMethodSpecificInput CardPaymentMethodSpecificInput { get; set; } = null;

        public Definitions.Merchant Merchant { get; set; } = null;

        public Order Order { get; set; } = null;
    }
}
