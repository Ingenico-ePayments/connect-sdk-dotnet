/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Product.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class CreatePaymentProductSessionRequest
    {
        /// <summary>
        /// Object containing details for creating an Apple Pay session.
        /// </summary>
        public MobilePaymentProductSession302SpecificInput PaymentProductSession302SpecificInput { get; set; } = null;
    }
}
