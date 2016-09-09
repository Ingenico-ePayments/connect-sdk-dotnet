/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CardPaymentMethodSpecificOutput">CardPaymentMethodSpecificOutput</a>
    /// </summary>
    public class CardPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        public string AuthorisationCode { get; set; } = null;

        public CardEssentials Card { get; set; } = null;

        public CardFraudResults FraudResults { get; set; } = null;

        public ThreeDSecureResults ThreeDSecureResults { get; set; } = null;
    }
}
