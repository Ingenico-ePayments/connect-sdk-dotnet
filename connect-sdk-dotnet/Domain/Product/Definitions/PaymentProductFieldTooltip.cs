/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductFieldTooltip
    {
        /// <summary>
        /// Relative URL that can be used to retrieve an image for the tooltip image. You can use our server-side resize functionality by appending '?size={{width}}x{{height}}' to the full URL, where width and height are specified in pixels. The resized image will always keep its correct aspect ratio.
        /// </summary>
        public string Image { get; set; } = null;

        /// <summary>
        /// A text explaining the field in more detail. This is meant to be used for displaying to the customer.
        /// </summary>
        public string Label { get; set; } = null;
    }
}
