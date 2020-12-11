/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CardPaymentMethodSpecificInput : AbstractCardPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object containing card details
        /// </summary>
        public Card Card { get; set; } = null;

        /// <summary>
        /// Object containing 3D secure details.
        /// </summary>
        [ObsoleteAttribute("Use threeDSecure.externalCardholderAuthenticationData instead")]
        public ExternalCardholderAuthenticationData ExternalCardholderAuthenticationData { get; set; } = null;

        /// <summary>
        /// Indicates if this transaction is of a one-off or a recurring type 
        /// <list type="bullet">
        ///   <item><description>true - This is recurring</description></item>
        ///   <item><description>false - This is one-off</description></item>
        /// </list>
        /// </summary>
        public bool? IsRecurring { get; set; } = null;

        /// <summary>
        /// Indicates reason behind the merchant initiated transaction. These are industry specific.
        /// <br />Possible values: 
        /// <list type="bullet">
        ///   <item><description>delayedCharges - Delayed charges are performed to process a supplemental account charge after original services have been rendered and respective payment has been processed. This is typically used in hotel, cruise lines and vehicle rental environments to perform a supplemental payment after the original services are rendered.</description></item>
        ///   <item><description>noShow - Cardholders can use their cards to make a guaranteed reservation with certain merchant segments. A guaranteed reservation ensures that the reservation will be honored and allows a merchant to perform a No Show transaction to charge the cardholder a penalty according to the merchant&#8217;s cancellation policy. For merchants that accept token-based payment credentials to guarantee a reservation, it is necessary to perform a customer initiated (Account Verification) at the time of reservation to be able perform a No Show transaction later.</description></item>
        /// </list>
        /// </summary>
        public string MerchantInitiatedReasonIndicator { get; set; } = null;

        /// <summary>
        /// The URL that the customer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the customer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process.
        /// <br />Note: The provided URL should be absolute and contain the protocol to use, e.g. http:// or https://. For use on mobile devices a custom protocol can be used in the form of 
        /// <i>protocol</i>://. This protocol must be registered on the device first.
        /// <br />URLs without a protocol will be rejected.
        /// </summary>
        [ObsoleteAttribute("Use threeDSecure.redirectionData.returnUrl instead")]
        public string ReturnUrl { get; set; } = null;

        /// <summary>
        /// Object containing specific data regarding 3-D Secure
        /// </summary>
        public ThreeDSecure ThreeDSecure { get; set; } = null;
    }
}
