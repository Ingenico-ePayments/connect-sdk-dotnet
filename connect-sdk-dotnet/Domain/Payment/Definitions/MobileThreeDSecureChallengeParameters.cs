/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class MobileThreeDSecureChallengeParameters
    {
        public string AcsReferenceNumber { get; set; } = null;

        public string AcsSignedContent { get; set; } = null;

        public string AcsTransactionId { get; set; } = null;

        public string ThreeDServerTransactionId { get; set; } = null;
    }
}
