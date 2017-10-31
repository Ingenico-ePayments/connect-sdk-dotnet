/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductFieldDisplayHints
    {
        public bool? AlwaysShow { get; set; } = null;

        public int? DisplayOrder { get; set; } = null;

        public PaymentProductFieldFormElement FormElement { get; set; } = null;

        public string Label { get; set; } = null;

        public string Link { get; set; } = null;

        public string Mask { get; set; } = null;

        public bool? Obfuscate { get; set; } = null;

        public string PlaceholderLabel { get; set; } = null;

        public string PreferredInputType { get; set; } = null;

        public PaymentProductFieldTooltip Tooltip { get; set; } = null;
    }
}
