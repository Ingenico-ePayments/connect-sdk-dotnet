/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class CompletePaymentRequest
    {
        /// <summary>
        /// Object containing the specific input details for card payments
        /// </summary>
        public CompletePaymentCardPaymentMethodSpecificInput CardPaymentMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing information on you, the merchant
        /// </summary>
        public Definitions.Merchant Merchant { get; set; } = null;

        /// <summary>
        /// Order object containing order related data
        /// </summary>
        public Order Order { get; set; } = null;
    }
}
