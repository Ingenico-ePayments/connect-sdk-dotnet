/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CardPaymentMethodSpecificInput">CardPaymentMethodSpecificInput</a>
    /// </summary>
    public class CardPaymentMethodSpecificInput : CardPaymentMethodSpecificInputBase
    {
        public Card Card { get; set; } = null;

        public ExternalCardholderAuthenticationData ExternalCardholderAuthenticationData { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public string ReturnUrl { get; set; } = null;
    }
}
