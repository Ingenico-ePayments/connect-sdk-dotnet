/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentCreationOutput">PaymentCreationOutput</a>
    /// </summary>
    public class PaymentCreationOutput : PaymentCreationReferences
    {
        public bool? IsNewToken { get; set; } = null;

        public string Token { get; set; } = null;
    }
}
