/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class HostedCheckoutSpecificOutput
    {
        /// <summary>
        /// The ID of the Hosted Checkout Session in which the payment was made.
        /// </summary>
        public string HostedCheckoutId { get; set; } = null;

        /// <summary>
        /// Using the Configuration Center it is possible to create multiple variations of your MyCheckout payment pages. By specifying a specific variant you can force the use of another variant then the default. This allows you to test out the effect of certain changes to your hosted mandate pages in a controlled manner. Please note that you need to specify the ID of the variant.
        /// </summary>
        public string Variant { get; set; } = null;
    }
}
