/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class OrderApprovePayment
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; } = null;

        /// <summary>
        /// Object containing data related to the customer
        /// </summary>
        public CustomerApprovePayment Customer { get; set; } = null;

        /// <summary>
        /// Object that holds all reference properties that are linked to this transaction
        /// </summary>
        public OrderReferencesApprovePayment References { get; set; } = null;
    }
}
