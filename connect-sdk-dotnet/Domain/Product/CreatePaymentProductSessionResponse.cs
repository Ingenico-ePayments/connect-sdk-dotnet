/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Product.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class CreatePaymentProductSessionResponse
    {
        /// <summary>
        /// Object containing the Apple Pay session object.
        /// </summary>
        public MobilePaymentProductSession302SpecificOutput PaymentProductSession302SpecificOutput { get; set; } = null;
    }
}
