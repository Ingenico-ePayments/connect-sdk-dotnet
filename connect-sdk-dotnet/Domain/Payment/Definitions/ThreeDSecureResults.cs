/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ThreeDSecureResults
    {
        public string AcsTransactionId { get; set; } = null;

        public string AppliedExemption { get; set; } = null;

        public AmountOfMoney AuthenticationAmount { get; set; } = null;

        public string Cavv { get; set; } = null;

        public string DirectoryServerTransactionId { get; set; } = null;

        public string Eci { get; set; } = null;

        public int? SchemeRiskScore { get; set; } = null;

        public SdkDataOutput SdkData { get; set; } = null;

        public ThreeDSecureData ThreeDSecureData { get; set; } = null;

        public string ThreeDSecureVersion { get; set; } = null;

        public string ThreeDServerTransactionId { get; set; } = null;

        public string Xid { get; set; } = null;
    }
}
