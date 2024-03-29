/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CompletePaymentCardPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object containing card details
        /// </summary>
        public CardWithoutCvv Card { get; set; } = null;
    }
}
