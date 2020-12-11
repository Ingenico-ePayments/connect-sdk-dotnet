/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductFieldFormElement
    {
        /// <summary>
        /// Type of form element to be used. The following types can be returned: 
        /// <list type="bullet">
        ///   <item><description>text - A normal text input field</description></item>
        ///   <item><description>list - A list of values that the customer needs to choose from, is detailed in the valueMapping array</description></item>
        ///   <item><description>currency - Currency fields should be split into two fields, with the second one being specifically for the cents</description></item>
        ///   <item><description>boolean - Boolean fields should offer the customer a choice, like accepting the terms and conditions of a product.</description></item>
        ///   <item><description>date - let the customer pick a date.</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; } = null;

        /// <summary>
        /// An array of values and displayNames that should be used to populate the list object in the GUI
        /// </summary>
        public IList<ValueMappingElement> ValueMapping { get; set; } = null;
    }
}
