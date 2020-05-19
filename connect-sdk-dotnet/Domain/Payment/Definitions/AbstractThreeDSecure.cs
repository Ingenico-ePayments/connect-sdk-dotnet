/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class AbstractThreeDSecure
    {
        public AmountOfMoney AuthenticationAmount { get; set; } = null;

        public string AuthenticationFlow { get; set; } = null;

        public string ChallengeCanvasSize { get; set; } = null;

        public string ChallengeIndicator { get; set; } = null;

        public string ExemptionRequest { get; set; } = null;

        public ThreeDSecureData PriorThreeDSecureData { get; set; } = null;

        public SdkDataInput SdkData { get; set; } = null;

        public bool? SkipAuthentication { get; set; } = null;
    }
}
