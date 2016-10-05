/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentProductFilter">PaymentProductFilter</a>
    /// </summary>
    public class PaymentProductFilter
    {
        public IList<string> Groups { get; set; } = null;

        public IList<int?> Products { get; set; } = null;
    }
}
