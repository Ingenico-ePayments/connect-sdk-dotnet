/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class GPayThreeDSecure
    {
        public string ChallengeCanvasSize { get; set; } = null;

        public string ChallengeIndicator { get; set; } = null;

        public string ExemptionRequest { get; set; } = null;

        public RedirectionData RedirectionData { get; set; } = null;

        public bool? SkipAuthentication { get; set; } = null;
    }
}
