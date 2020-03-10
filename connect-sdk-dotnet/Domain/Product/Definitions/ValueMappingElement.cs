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
        public IList<PaymentProductFieldDisplayElement> DisplayElements { get; set; } = null;

        [ObsoleteAttribute("Use displayElements instead with ID 'displayName'")]
        public string DisplayName { get; set; } = null;

        public string Value { get; set; } = null;
    }
}
