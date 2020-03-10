/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CardPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        public string AuthorisationCode { get; set; } = null;

        public CardEssentials Card { get; set; } = null;

        public CardFraudResults FraudResults { get; set; } = null;

        public string InitialSchemeTransactionId { get; set; } = null;

        public string SchemeTransactionId { get; set; } = null;

        public ThreeDSecureResults ThreeDSecureResults { get; set; } = null;

        public string Token { get; set; } = null;
    }
}
