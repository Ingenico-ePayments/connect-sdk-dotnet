/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class GPayThreeDSecure
    {
        /// <summary>
        /// Dimensions of the challenge window that potentially will be displayed to the customer. The challenge content is formatted to appropriately render in this window to provide the best possible user experience.
        /// <br />Preconfigured sizes are width x height in pixels of the window displayed in the customer browser window. Possible values are:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>250x400 (default)</description></item>
        ///   <item><description>390x400</description></item>
        ///   <item><description>500x600</description></item>
        ///   <item><description>600x400</description></item>
        ///   <item><description>full-screen</description></item>
        /// </list>.
        /// </summary>
        public string ChallengeCanvasSize { get; set; } = null;

        /// <summary>
        /// Allows you to indicate if you want the customer to be challenged for extra security on this transaction. Possible values: 
        /// <list type="bullet">
        ///   <item><description>no-preference - You have no preference whether or not to challenge the customer (default)</description></item>
        ///   <item><description>no-challenge-requested - you prefer the cardholder not to be challenged</description></item>
        ///   <item><description>challenge-requested - you prefer the customer to be challenged</description></item>
        ///   <item><description>challenge-required - you require the customer to be challenged</description></item>
        /// </list>
        /// </summary>
        public string ChallengeIndicator { get; set; } = null;

        /// <summary>
        /// Type of strong customer authentication (SCA) exemption requested for this transaction. Possible values:
        /// <list type="bullet">
        ///   <item><description>none - No exemption flagging is to be used of this transaction (Default).</description></item>
        ///   <item><description>automatic - Our systems will determine the best possible exemption based on the transaction parameters and the risk scores.</description></item>
        ///   <item><description>transaction-risk-analysis - You have determined that this transaction is of low risk and are willing to take the liability. Please note that your fraud rate needs to stay below thresholds to allow your use of this exemption.</description></item>
        ///   <item><description>low-value - The value of the transaction is below 30 EUR. Please note that the issuer will still require every 5th low-value transaction pithing 24 hours to be strongly authenticated. The issuer will also keep track of the cumulative amount authorized on the card. When this exceeds 100 EUR strong customer authentication is also required.</description></item>
        ///   <item><description>whitelist - You have been whitelisted by the customer at the issuer.</description></item>
        /// </list>
        /// </summary>
        public string ExemptionRequest { get; set; } = null;

        /// <summary>
        /// Object containing browser specific redirection related data
        /// </summary>
        public RedirectionData RedirectionData { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true = 3D Secure authentication will be skipped for this transaction. This setting should be used when isRecurring is set to true and recurringPaymentSequenceIndicator is set to recurring.</description></item>
        ///   <item><description>false = 3D Secure authentication will not be skipped for this transaction.</description></item>
        /// </list>Note: This is only possible if your account in our system is setup for 3D Secure authentication and if your configuration in our system allows you to override it per transaction.
        /// </summary>
        public bool? SkipAuthentication { get; set; } = null;
    }
}
