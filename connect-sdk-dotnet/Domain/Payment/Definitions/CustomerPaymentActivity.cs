/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CustomerPaymentActivity
    {
        /// <summary>
        /// Number of payment attempts (so including unsuccessful ones) made by this customer with you in the last 24 hours
        /// </summary>
        public int? NumberOfPaymentAttemptsLast24Hours { get; set; } = null;

        /// <summary>
        /// Number of payment attempts (so including unsuccessful ones) made by this customer with you in the last 12 months
        /// </summary>
        public int? NumberOfPaymentAttemptsLastYear { get; set; } = null;

        /// <summary>
        /// Number of successful purchases made by this customer with you in the last 6 months
        /// </summary>
        public int? NumberOfPurchasesLast6Months { get; set; } = null;
    }
}
