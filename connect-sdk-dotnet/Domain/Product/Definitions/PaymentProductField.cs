/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductField
    {
        /// <summary>
        /// Object containing data restrictions that apply to this field, like minimum and/or maximum length
        /// </summary>
        public PaymentProductFieldDataRestrictions DataRestrictions { get; set; } = null;

        /// <summary>
        /// Object containing display hints for this field, like the order, mask, preferred keyboard
        /// </summary>
        public PaymentProductFieldDisplayHints DisplayHints { get; set; } = null;

        /// <summary>
        /// The ID of the field
        /// </summary>
        public string Id { get; set; } = null;

        /// <summary>
        /// The type of field, possible values are: 
        /// <list type="bullet">
        ///   <item><description>string - Any UTF-8 chracters</description></item>
        ///   <item><description>numericstring - A string that consisting only of numbers. Note that you should strip out anything that is not a digit, but leading zeros are allowed</description></item>
        ///   <item><description>date - Date in the format DDMMYYYY</description></item>
        ///   <item><description>expirydate - Expiration date in the format MMYY</description></item>
        ///   <item><description>integer - An integer</description></item>
        ///   <item><description>boolean - A boolean</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; } = null;

        /// <summary>
        /// Indicates that the product can be used in a 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/products/customerDetails.html">get customer details</a> call and that when that call is done the field should be supplied as (one of the) key(s) with a valid value.
        /// </summary>
        public bool? UsedForLookup { get; set; } = null;
    }
}
