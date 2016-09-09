/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentProductFieldFormElement">PaymentProductFieldFormElement</a>
    /// </summary>
    public class PaymentProductFieldFormElement
    {
        public string Type { get; set; } = null;

        public IList<ValueMappingElement> ValueMapping { get; set; } = null;
    }
}
