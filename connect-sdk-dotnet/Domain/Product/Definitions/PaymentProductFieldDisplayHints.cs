/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductFieldDisplayHints
    {
        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - Indicates that this field is advised to be captured to increase the success rates even though it isn't marked as required. Please note that making the field required could hurt the success rates negatively. This boolean only indicates our advise to always show this field to the customer.</description></item>
        ///   <item><description>false - Indicates that this field is not to be shown unless it is a required field.</description></item>
        /// </list>
        /// </summary>
        public bool? AlwaysShow { get; set; } = null;

        /// <summary>
        /// The order in which the fields should be shown (ascending)
        /// </summary>
        public int? DisplayOrder { get; set; } = null;

        /// <summary>
        /// Object detailing the type of form element that should be used to present the field
        /// </summary>
        public PaymentProductFieldFormElement FormElement { get; set; } = null;

        /// <summary>
        /// Label/Name of the field to be used in the user interface
        /// </summary>
        public string Label { get; set; } = null;

        /// <summary>
        /// Link that should be used to replace the '{link}' variable in the label.
        /// </summary>
        public string Link { get; set; } = null;

        /// <summary>
        /// A mask that can be used in the input field. You can use it to inject additional characters to provide a better user experience and to restrict the accepted character set (illegal characters to be ignored during typing).
        /// <br />* is used for wildcards (and also chars)
        /// <br />9 is used for numbers
        /// <br />Everything outside {{ and }} is used as-is.
        /// </summary>
        public string Mask { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - The data in this field should be obfuscated as it is entered, just like a password field</description></item>
        ///   <item><description>false - The data in this field does not need to be obfuscated</description></item>
        /// </list>
        /// </summary>
        public bool? Obfuscate { get; set; } = null;

        /// <summary>
        /// A placeholder value for the form element
        /// </summary>
        public string PlaceholderLabel { get; set; } = null;

        /// <summary>
        /// The type of keyboard that can best be used to fill out the value of this field. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>PhoneNumberKeyboard - Keyboard that is normally used to enter phone numbers</description></item>
        ///   <item><description>StringKeyboard - Keyboard that is used to enter strings</description></item>
        ///   <item><description>IntegerKeyboard - Keyboard that is used to enter only numerical values</description></item>
        ///   <item><description>EmailAddressKeyboard - Keyboard that allows easier entry of email addresses</description></item>
        /// </list>
        /// </summary>
        public string PreferredInputType { get; set; } = null;

        /// <summary>
        /// Object that contains an optional tooltip to assist the customer
        /// </summary>
        public PaymentProductFieldTooltip Tooltip { get; set; } = null;
    }
}
