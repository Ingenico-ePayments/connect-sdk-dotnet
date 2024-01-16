/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ThreeDSecure : AbstractThreeDSecure
    {
        /// <summary>
        /// Object containing 3D secure details.
        /// </summary>
        public ExternalCardholderAuthenticationData ExternalCardholderAuthenticationData { get; set; } = null;

        /// <summary>
        /// Object containing browser specific redirection related data
        /// </summary>
        public RedirectionData RedirectionData { get; set; } = null;
    }
}
