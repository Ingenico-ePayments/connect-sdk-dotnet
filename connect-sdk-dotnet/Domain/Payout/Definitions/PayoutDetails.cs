/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    public class PayoutDetails
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// Object containing the details of the customer.
        /// </summary>
        public PayoutCustomer Customer { get; set; } = null;

        /// <summary>
        /// Object that holds all reference properties that are linked to this transaction
        /// </summary>
        public PayoutReferences References { get; set; } = null;
    }
}
