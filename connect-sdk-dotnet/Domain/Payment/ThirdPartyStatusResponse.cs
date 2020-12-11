/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class ThirdPartyStatusResponse
    {
        /// <summary>
        /// The status returned by the third party. Possible values: 
        /// <list type="bullet">
        ///   <item><description>WAITING - The customer has not connected to the third party</description></item>
        ///   <item><description>INITIALIZED - Authentication in progress</description></item>
        ///   <item><description>AUTHORIZED - Payment in progress</description></item>
        ///   <item><description>COMPLETED - The customer has completed the payment at the third party</description></item>
        /// </list>
        /// </summary>
        public string ThirdPartyStatus { get; set; } = null;
    }
}
