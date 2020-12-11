/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class MobileThreeDSecureChallengeParameters
    {
        /// <summary>
        /// The unique identifier assigned by the EMVCo Secretariat upon testing and approval.
        /// </summary>
        public string AcsReferenceNumber { get; set; } = null;

        /// <summary>
        /// Contains the JWS object created by the ACS for the challenge (ARes).
        /// </summary>
        public string AcsSignedContent { get; set; } = null;

        /// <summary>
        /// The ACS Transaction ID for a prior 3-D Secure authenticated transaction (for example, the first recurring transaction that was authenticated with the customer).
        /// </summary>
        public string AcsTransactionId { get; set; } = null;

        /// <summary>
        /// The 3-D Secure version 2 transaction ID that is used for the 3D Authentication
        /// </summary>
        public string ThreeDServerTransactionId { get; set; } = null;
    }
}
