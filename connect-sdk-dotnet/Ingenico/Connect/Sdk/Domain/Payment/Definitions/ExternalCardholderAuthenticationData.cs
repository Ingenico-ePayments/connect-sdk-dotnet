/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_ExternalCardholderAuthenticationData">ExternalCardholderAuthenticationData</a>
    /// </summary>
    public class ExternalCardholderAuthenticationData
    {
        public string Cavv { get; set; } = null;

        public string CavvAlgorithm { get; set; } = null;

        public int? Eci { get; set; } = null;

        public string ValidationResult { get; set; } = null;

        public string Xid { get; set; } = null;
    }
}
