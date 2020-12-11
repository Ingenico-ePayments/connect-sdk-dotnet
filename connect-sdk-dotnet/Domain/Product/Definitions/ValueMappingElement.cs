/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class ValueMappingElement
    {
        /// <summary>
        /// List of extra data of the value.
        /// </summary>
        public IList<PaymentProductFieldDisplayElement> DisplayElements { get; set; } = null;

        /// <summary>
        /// Key name
        /// </summary>
        [ObsoleteAttribute("Use displayElements instead with ID 'displayName'")]
        public string DisplayName { get; set; } = null;

        /// <summary>
        /// Value corresponding to the key
        /// </summary>
        public string Value { get; set; } = null;
    }
}
