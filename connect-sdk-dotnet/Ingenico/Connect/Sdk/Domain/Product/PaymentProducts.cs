/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Product.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentProducts">PaymentProducts</a>
    /// </summary>
    public class PaymentProducts
    {
        /// <summary>
        /// Property paymentProducts
        /// </summary>
        [JsonProperty(PropertyName = "paymentProducts")]
        public IList<PaymentProduct> ListOfPaymentProducts { get; set; } = null;
    }
}
