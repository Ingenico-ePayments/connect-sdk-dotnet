/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    [Obsolete("No replacement")]
    public class CashPaymentProduct1503SpecificInput
    {
        /// <summary>
        /// The URL that the customer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the customer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process.
        /// <br />Note: The provided URL should be absolute and contain the protocol to use, e.g. http:// or https://. For use on mobile devices a custom protocol can be used in the form of 
        /// <i>protocol</i>://. This protocol must be registered on the device first.
        /// <br />URLs without a protocol will be rejected.
        /// </summary>
        [Obsolete("No replacement, since Boleto Bancario no longer needs a return URL")]
        public string ReturnUrl { get; set; } = null;
    }
}
