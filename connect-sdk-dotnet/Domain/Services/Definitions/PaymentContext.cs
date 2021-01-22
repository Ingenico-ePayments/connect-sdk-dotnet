/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services.Definitions
{
    public class PaymentContext
    {
        /// <summary>
        /// The payment amount
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// The country the payment takes place in
        /// </summary>
        public string CountryCode { get; set; } = null;

        /// <summary>
        /// True if the payment is recurring
        /// </summary>
        public bool? IsRecurring { get; set; } = null;
    }
}