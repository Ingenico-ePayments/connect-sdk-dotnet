/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System.Collections.Generic;
using KeyValuePair = Ingenico.Connect.Sdk.Domain.Definitions.KeyValuePair;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentStatusOutput : OrderStatusOutput
    {
        /// <summary>
        /// Indicates if the transaction has been authorized 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsAuthorized { get; set; } = null;

        /// <summary>
        /// Flag indicating if the payment can be refunded 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsRefundable { get; set; } = null;

        /// <summary>
        /// Flag indicating whether a rejected payment may be retried by the merchant without incurring a fee 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? IsRetriable { get; set; } = null;

        /// <summary>
        /// This is the raw response returned by the acquirer. This property contains unprocessed data directly returned by the acquirer. It's recommended for data analysis only due to its dynamic nature, which may undergo future changes.
        /// </summary>
        public IList<KeyValuePair> ProviderRawOutput { get; set; } = null;

        /// <summary>
        /// The 3D Secure status, with the following possible values: 
        /// <list type="bullet">
        ///   <item><description>ENROLLED: the card is enrolled for 3D Secure authentication. The customer can be redirected to a 3D Secure access control server (ACS)</description></item>
        ///   <item><description>NOT_ENROLLED: the card is not enrolled for 3D Secure authentication</description></item>
        ///   <item><description>INVALID_PARES_OR_NOT_COMPLETED: the PARes is invalid, or the customer did not complete the 3D Secure authentication</description></item>
        ///   <item><description>AUTHENTICATED: the customer has passed the 3D Secure authentication</description></item>
        ///   <item><description>NOT_AUTHENTICATED: the customer failed the 3D Secure authentication</description></item>
        ///   <item><description>NOT_PARTICIPATING: the cardholder has not set up their card for 2-step 3D Secure.</description></item>
        /// </list>Note that this status will only be set for payments that make use of 2-step 3D Secure.
        /// </summary>
        public string ThreeDSecureStatus { get; set; } = null;
    }
}
