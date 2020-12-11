/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CardPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Card Authorization code as returned by the acquirer
        /// </summary>
        public string AuthorisationCode { get; set; } = null;

        /// <summary>
        /// Object containing card details
        /// </summary>
        public CardEssentials Card { get; set; } = null;

        /// <summary>
        /// Fraud results contained in the CardFraudResults object
        /// </summary>
        public CardFraudResults FraudResults { get; set; } = null;

        /// <summary>
        /// The unique scheme transactionId of the initial transaction that was performed with SCA.
        /// <br />Should be stored by the merchant to allow it to be submitted in future transactions.
        /// </summary>
        public string InitialSchemeTransactionId { get; set; } = null;

        /// <summary>
        /// The unique scheme transactionId of this transaction.
        /// <br />Should be stored by the merchant to allow it to be submitted in future transactions. Use this value in case the initialSchemeTransactionId property is empty.
        /// </summary>
        public string SchemeTransactionId { get; set; } = null;

        /// <summary>
        /// 3D Secure results object
        /// </summary>
        public ThreeDSecureResults ThreeDSecureResults { get; set; } = null;

        /// <summary>
        /// If a token was used for or created during the payment, then the ID of that token.
        /// </summary>
        public string Token { get; set; } = null;
    }
}
