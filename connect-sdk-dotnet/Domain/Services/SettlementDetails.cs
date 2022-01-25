/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services
{
    public class SettlementDetails
    {
        /// <summary>
        /// The Acquirer Reference Number (ARN) is a unique identifier assigned to a card payment as it moves through the payment network.
        /// </summary>
        public string AcquirerReferenceNumber { get; set; } = null;

        /// <summary>
        /// The payment amount
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// Our unique payment transaction identifier.
        /// </summary>
        public string PaymentId { get; set; } = null;

        /// <summary>
        /// The Retrieval Reference Number (RRN) provides a unique reference for a card payment, pinpointing it to a specific date.
        /// </summary>
        public string RetrievalReferenceNumber { get; set; } = null;
    }
}
