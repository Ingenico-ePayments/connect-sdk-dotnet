/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CardRecurrenceDetails
    {
        /// <summary>
        /// Date in YYYYMMDD after which there will be no further charges. If no value is provided we will set a default value of five years after we processed the first recurring transaction.
        /// </summary>
        public string EndDate { get; set; } = null;

        /// <summary>
        /// Minimum number of days between authorizations. If no value is provided we will set a default value of 30 days.
        /// </summary>
        public int? MinFrequency { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>first = This transaction is the first of a series of recurring transactions</description></item>
        ///   <item><description>recurring = This transaction is a subsequent transaction in a series of recurring transactions</description></item>
        /// </list>
        /// <br />Note: For any first of a recurring the system will automatically create a token as you will need to use a token for any subsequent recurring transactions. In case a token already exists this is indicated in the response with a value of False for the isNewToken property in the response.
        /// </summary>
        public string RecurringPaymentSequenceIndicator { get; set; } = null;
    }
}
