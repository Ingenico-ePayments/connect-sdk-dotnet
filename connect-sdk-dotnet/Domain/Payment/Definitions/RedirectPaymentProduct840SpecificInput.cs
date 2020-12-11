/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentProduct840SpecificInput : AbstractRedirectPaymentProduct840SpecificInput
    {
        /// <summary>
        /// A free text string that you can send to PayPal. With a special agreement between PayPal and you, PayPal uses the data in that property, for custom services they offer to you.
        /// </summary>
        [ObsoleteAttribute("Use Order.references.descriptor instead")]
        public string Custom { get; set; } = null;

        /// <summary>
        /// <div class="deprecated-wrapper depends-wrapper">Deprecated: If your PayPal payments are processed by Ingenico's Ogone Payment Platform, please use the property addressSelectionAtPayPal instead.</div>
        /// <br />Indicates whether to use PayPal Express Checkout for payments processed by Ingenico's GlobalCollect Payment Platform. 
        /// <list type="bullet">
        ///   <item><description>true = PayPal Express Checkout</description></item>
        ///   <item><description>false = Regular PayPal payment</description></item>
        /// </list>For payments processed by Ingenico's Ogone Payment Platform, please see the addressSelectionAtPayPal property for more information.
        /// </summary>
        public bool? IsShortcut { get; set; } = null;
    }
}
