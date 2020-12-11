/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class PaymentProductNetworksResponse
    {
        /// <summary>
        /// Array containing network entries for a payment product. The strings that represent the networks in the array are identical to the strings that the payment product vendors use in their documentation. For instance: "Visa" for 
        /// <a href="https://developer.apple.com/reference/passkit/pkpaymentnetwork" target="_blank">Apple Pay</a>, and "VISA" for 
        /// <a href="https://developers.google.com/pay/api/android/reference/object#CardParameters" target="_blank">Google Pay</a>.
        /// </summary>
        public IList<string> Networks { get; set; } = null;
    }
}
