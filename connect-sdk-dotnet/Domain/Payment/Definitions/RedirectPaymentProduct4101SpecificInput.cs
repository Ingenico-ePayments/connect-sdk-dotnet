/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
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
        /// The value of this property must be 'vpa', 'desktopQRCode', or 'urlIntent'.
        /// </summary>
        public string IntegrationType { get; set; } = null;

        /// <summary>
        /// The Virtual Payment Address (VPA) of the customer. The '+' character is not allowed in this property for transactions that are processed by TechProcess Payment Platform.
        /// </summary>
        public string VirtualPaymentAddress { get; set; } = null;
    }
}
