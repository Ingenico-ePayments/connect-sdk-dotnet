/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class FraudResults
    {
        /// <summary>
        /// Results from the fraud prevention check. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>accepted - Based on the checks performed the transaction can be accepted</description></item>
        ///   <item><description>challenged - Based on the checks performed the transaction should be manually reviewed</description></item>
        ///   <item><description>denied - Based on the checks performed the transaction should be rejected</description></item>
        ///   <item><description>no-advice - No fraud check was requested/performed</description></item>
        ///   <item><description>error - The fraud check resulted in an error and the fraud check was thus not performed</description></item>
        /// </list>
        /// </summary>
        public string FraudServiceResult { get; set; } = null;

        /// <summary>
        /// Object containing device fingerprinting details from InAuth
        /// </summary>
        public InAuth InAuth { get; set; } = null;
    }
}
