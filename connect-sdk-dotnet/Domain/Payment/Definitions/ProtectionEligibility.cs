/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ProtectionEligibility
    {
        /// <summary>
        /// Possible values: 
        /// <list type="bullet">
        ///   <item><description>Eligible</description></item>
        ///   <item><description>PartiallyEligible</description></item>
        ///   <item><description>Ineligible</description></item>
        /// </list>
        /// </summary>
        public string Eligibility { get; set; } = null;

        /// <summary>
        /// Possible values: 
        /// <list type="bullet">
        ///   <item><description>ItemNotReceivedEligible</description></item>
        ///   <item><description>UnauthorizedPaymentEligible</description></item>
        ///   <item><description>Ineligible</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; } = null;
    }
}
