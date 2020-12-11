/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    public class CustomerDeviceRiskAssessment
    {
        /// <summary>
        /// Degree of default form fill, with the following possible values: 
        /// <list type="bullet">
        ///   <item><description>automatically - All fields filled automatically</description></item>
        ///   <item><description>automatically-but-modified - All fields filled automatically, but some fields were modified manually</description></item>
        ///   <item><description>manually - All fields were entered manually</description></item>
        /// </list>
        /// </summary>
        public string DefaultFormFill { get; set; } = null;

        /// <summary>
        /// One must set the deviceFingerprintTransactionId received by the response of the endpoint /{merchant}/products/{paymentProductId}/deviceFingerprint
        /// </summary>
        public string DeviceFingerprintTransactionId { get; set; } = null;
    }
}
