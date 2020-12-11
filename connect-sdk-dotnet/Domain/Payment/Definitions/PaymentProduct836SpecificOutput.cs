/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentProduct836SpecificOutput
    {
        /// <summary>
        /// Indicates if SofortBank could estabilish if the transaction could successfully be processed. 
        /// <list type="bullet">
        ///   <item><description>0 - You should wait for the transaction to be reported as paid before shipping any goods.</description></item>
        ///   <item><description>1 - You can ship the goods. In case the transaction is not reported as paid you can initiate a claims process with SofortBank.</description></item>
        /// </list>
        /// </summary>
        public string SecurityIndicator { get; set; } = null;
    }
}
