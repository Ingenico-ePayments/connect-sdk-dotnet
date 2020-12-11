/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProduct320SpecificData
    {
        /// <summary>
        /// The GlobalCollect gateway identifier. You should use this when creating a 
        /// <a href="https://developers.google.com/pay/api/android/reference/object#Gateway" target="_blank">tokenization specification</a>.
        /// </summary>
        public string Gateway { get; set; } = null;

        /// <summary>
        /// The networks that can be used in the current payment context. The strings that represent the networks in the array are identical to the strings that Google uses in their 
        /// <a href="https://developers.google.com/pay/api/android/reference/object#CardParameters" target="_blank">documentation</a>. For instance: "VISA".
        /// </summary>
        public IList<string> Networks { get; set; } = null;
    }
}
