/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductFieldDisplayElement
    {
        /// <summary>
        /// The ID of the display element.
        /// </summary>
        public string Id { get; set; } = null;

        /// <summary>
        /// The label of the display element.
        /// </summary>
        public string Label { get; set; } = null;

        /// <summary>
        /// The type of the display element. Indicates how the value should be presented. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>STRING - as plain text</description></item>
        ///   <item><description>CURRENCY - as an amount in cents displayed with a decimal separator and the currency of the payment</description></item>
        ///   <item><description>PERCENTAGE - as a number with a percentage sign</description></item>
        ///   <item><description>INTEGER - as an integer</description></item>
        ///   <item><description>URI - as a link</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; } = null;

        /// <summary>
        /// the value of the display element.
        /// </summary>
        public string Value { get; set; } = null;
    }
}
