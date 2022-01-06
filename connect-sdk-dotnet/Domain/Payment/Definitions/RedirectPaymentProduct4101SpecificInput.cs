/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentProduct4101SpecificInput
    {
        /// <summary>
        /// The merchant name as shown to the customer in some payment applications.
        /// </summary>
        public string DisplayName { get; set; } = null;

        /// <summary>
        /// The value of this property must be either or 'vpa', or 'mobile'.
        /// </summary>
        public string IntegrationType { get; set; } = null;

        /// <summary>
        /// The Virtual Payment Address (VPA) of the customer.
        /// </summary>
        public string VirtualPaymentAddress { get; set; } = null;
    }
}
