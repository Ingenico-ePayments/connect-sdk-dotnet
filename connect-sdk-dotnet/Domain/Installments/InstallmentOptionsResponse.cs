/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Installments.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Installments
{
    public class InstallmentOptionsResponse
    {
        /// <summary>
        /// Array containing installment options their details and characteristics
        /// </summary>
        public IList<InstallmentOptions> InstallmentOptions { get; set; } = null;
    }
}
