/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CardPaymentMethodSpecificInputBase : AbstractCardPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object containing specific data regarding 3-D Secure
        /// </summary>
        public ThreeDSecureBase ThreeDSecure { get; set; } = null;
    }
}
