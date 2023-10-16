/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Installments.Definitions
{
    public class InstallmentOptions
    {
        /// <summary>
        /// Object containing information for the client on how best to display the installment options
        /// </summary>
        public InstallmentDisplayHints DisplayHints { get; set; } = null;

        /// <summary>
        /// The ID of the installment option in our system
        /// </summary>
        public string Id { get; set; } = null;

        /// <summary>
        /// Object containing information about installment plans
        /// </summary>
        public IList<Payment.Definitions.Installments> InstallmentPlans { get; set; } = null;
    }
}
