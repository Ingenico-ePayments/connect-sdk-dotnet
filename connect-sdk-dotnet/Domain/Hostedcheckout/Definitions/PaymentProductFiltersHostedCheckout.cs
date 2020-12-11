/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class PaymentProductFiltersHostedCheckout
    {
        /// <summary>
        /// Contains the payment product ids and payment product groups that should be excluded from the payment products available for the payment. Note that excluding a payment product will ensure exclusion, even if the payment product is also present in the restrictTo filter, and that excluding a payment product group will exclude all payment products that are a part of that group, even if one or more of them are present in the restrictTo filters.
        /// </summary>
        public PaymentProductFilter Exclude { get; set; } = null;

        /// <summary>
        /// Contains the payment product ids and payment product groups that should be at most contained in the payment products available for completing the payment. Note that the list of payment products available for completing the payment will only contain payment products present in these filters, but not all payment products in these filters might be present in the list. Some of them might not be allowed in context or they might be present in the exclude filters.
        /// </summary>
        public PaymentProductFilter RestrictTo { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - The customer may only complete the payment using one of the provided accounts on file.</description></item>
        ///   <item><description>false -The customer can complete the payment using any way they like, as long as it is allowed in the payment context. Default.</description></item>
        /// </list>Note that the request must contain at least one valid account on file with an allowed payment product (not excluded and allowed in context) if this property is set to true, else the request will fail.
        /// </summary>
        public bool? TokensOnly { get; set; } = null;
    }
}
