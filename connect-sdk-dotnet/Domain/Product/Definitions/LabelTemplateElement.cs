/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class LabelTemplateElement
    {
        /// <summary>
        /// Name of the attribute that is shown to the customer on selection pages or screens
        /// </summary>
        public string AttributeKey { get; set; } = null;

        /// <summary>
        /// Regular mask for the attributeKey
        /// <br />Note: The mask is optional as not every field has a mask
        /// </summary>
        public string Mask { get; set; } = null;
    }
}
