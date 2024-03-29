/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Product.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class PaymentProducts
    {
        /// <summary>
        /// Property paymentProducts
        /// <br />
        /// Array containing payment products and their characteristics
        /// </summary>
        [JsonProperty(PropertyName = "paymentProducts")]
        public IList<PaymentProduct> ListOfPaymentProducts { get; set; } = null;
    }
}
