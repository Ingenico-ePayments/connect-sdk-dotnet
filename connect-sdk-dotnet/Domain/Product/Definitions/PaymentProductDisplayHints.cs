/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductDisplayHints
    {
        /// <summary>
        /// Determines the order in which the payment products and groups should be shown (sorted ascending)
        /// </summary>
        public int? DisplayOrder { get; set; } = null;

        /// <summary>
        /// Name of the field based on the locale that was included in the request
        /// </summary>
        public string Label { get; set; } = null;

        /// <summary>
        /// Partial URL that you can reference for the image of this payment product. You can use our server-side resize functionality by appending '?size={{width}}x{{height}}' to the full URL, where width and height are specified in pixels. The resized image will always keep its correct aspect ratio.
        /// </summary>
        public string Logo { get; set; } = null;
    }
}
