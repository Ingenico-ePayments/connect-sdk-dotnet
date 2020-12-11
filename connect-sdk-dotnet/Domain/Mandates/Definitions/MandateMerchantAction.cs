/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Mandates.Definitions
{
    public class MandateMerchantAction
    {
        /// <summary>
        /// Action merchants needs to take in the online mandate process. Possible values are:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>REDIRECT - The customer needs to be redirected using the details found in redirectData</description></item>
        /// </list>
        /// </summary>
        public string ActionType { get; set; } = null;

        /// <summary>
        /// Object containing all data needed to redirect the customer
        /// </summary>
        public MandateRedirectData RedirectData { get; set; } = null;
    }
}
