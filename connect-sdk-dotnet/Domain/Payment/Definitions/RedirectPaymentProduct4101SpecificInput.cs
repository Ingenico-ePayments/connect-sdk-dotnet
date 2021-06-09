/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentProduct4101SpecificInput
    {
        /// <summary>
        /// The integration type to be used in the UPI payment
        /// </summary>
        public string IntegrationType { get; set; } = null;

        /// <summary>
        /// The virtual payment address.
        /// </summary>
        public string Vpa { get; set; } = null;
    }
}
