/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentProduct861SpecificInput
    {
        /// <summary>
        /// This indicates that a customer is on a mobile device and it is used to distinguish whether a customer should be redirected to AliPay Desktop or Mobile. Alternatively, if you cannot determine whether a customer is on a mobile device or not, a customer can be redirected to AliPay Mobile if the property CreatePaymentRequest.order.customer.device.userAgent is supplied.
        /// </summary>
        public bool? MobileDevice { get; set; } = null;
    }
}
