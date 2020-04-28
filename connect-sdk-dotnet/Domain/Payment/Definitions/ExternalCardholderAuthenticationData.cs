/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ExternalCardholderAuthenticationData
    {
        public string AcsTransactionId { get; set; } = null;

        public string AppliedExemption { get; set; } = null;

        public string Cavv { get; set; } = null;

        public string CavvAlgorithm { get; set; } = null;

        public string DirectoryServerTransactionId { get; set; } = null;

        public int? Eci { get; set; } = null;

        public int? SchemeRiskScore { get; set; } = null;

        public string ThreeDSecureVersion { get; set; } = null;

        [ObsoleteAttribute("No replacement")]
        public string ThreeDServerTransactionId { get; set; } = null;

        public string ValidationResult { get; set; } = null;

        public string Xid { get; set; } = null;
    }
}
