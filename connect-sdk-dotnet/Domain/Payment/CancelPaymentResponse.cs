/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class CancelPaymentResponse
    {
        /// <summary>
        /// Object that holds specific information on cancelled card payments
        /// </summary>
        public CancelPaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object that holds specific information on cancelled mobile payments
        /// </summary>
        public CancelPaymentMobilePaymentMethodSpecificOutput MobilePaymentMethodSpecificOutput { get; set; } = null;

        /// <summary>
        /// Object that holds the payment related properties
        /// </summary>
        public Definitions.Payment Payment { get; set; } = null;
    }
}
