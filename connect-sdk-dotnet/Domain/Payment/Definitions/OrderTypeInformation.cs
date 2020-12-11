/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class OrderTypeInformation
    {
        /// <summary>
        /// Possible values are:
        /// <list type="bullet">
        ///   <item><description>physical</description></item>
        ///   <item><description>digital</description></item>
        /// </list>
        /// </summary>
        public string PurchaseType { get; set; } = null;

        /// <summary>
        /// Identifies the type of transaction being authenticated. Possible values are:
        /// <list type="bullet">
        ///   <item><description>purchase = The purpose of the transaction is to purchase goods or services (Default)</description></item>
        ///   <item><description>check-acceptance = The purpose of the transaction is to accept a 'check'/'cheque'</description></item>
        ///   <item><description>account-funding = The purpose of the transaction is to fund an account</description></item>
        ///   <item><description>quasi-cash = The purpose of the transaction is to buy a quasi cash type product that is representative of actual cash such as money orders, traveler's checks, foreign currency, lottery tickets or casino gaming chips</description></item>
        ///   <item><description>prepaid-activation-or-load = The purpose of the transaction is to activate or load a prepaid card</description></item>
        /// </list>
        /// </summary>
        public string TransactionType { get; set; } = null;

        /// <summary>
        /// Possible values are:
        /// <list type="bullet">
        ///   <item><description>private</description></item>
        ///   <item><description>commercial</description></item>
        /// </list>
        /// </summary>
        public string UsageType { get; set; } = null;
    }
}
