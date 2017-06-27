/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Product.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class PaymentProductGroups
    {
        /// <summary>
        /// Property paymentProductGroups
        /// </summary>
        [JsonProperty(PropertyName = "paymentProductGroups")]
        public IList<PaymentProductGroup> ListOfPaymentProductGroups { get; set; } = null;
    }
}
