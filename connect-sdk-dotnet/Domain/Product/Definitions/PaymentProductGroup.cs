/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductGroup
    {
        /// <summary>
        /// Only populated in the Client API
        /// </summary>
        public IList<AccountOnFile> AccountsOnFile { get; set; } = null;

        /// <summary>
        /// Indicates if the product supports installments 
        /// <list type="bullet">
        ///   <item><description>true - This payment supports installments</description></item>
        ///   <item><description>false - This payment does not support installments</description></item>
        /// </list>
        /// </summary>
        public bool? AllowsInstallments { get; set; } = null;

        /// <summary>
        /// Indicates if device fingerprint is enabled for the product group 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? DeviceFingerprintEnabled { get; set; } = null;

        /// <summary>
        /// Object containing display hints like the order of the group when shown in a list, the name of the group and the logo. Note that the order of the group is the lowest order among the payment products that belong to the group.
        /// </summary>
        public PaymentProductDisplayHints DisplayHints { get; set; } = null;

        /// <summary>
        /// Object containing all the fields and their details that are associated with this payment product group. If you are not interested in the these fields you can have us filter them out (using hide=fields in the query-string)
        /// </summary>
        public IList<PaymentProductField> Fields { get; set; } = null;

        /// <summary>
        /// The ID of the payment product group in our system
        /// </summary>
        public string Id { get; set; } = null;
    }
}
