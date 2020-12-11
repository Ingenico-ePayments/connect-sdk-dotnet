/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class ValidationBankAccountOutput
    {
        /// <summary>
        /// Array of checks performed with the results of each check
        /// </summary>
        public IList<ValidationBankAccountCheck> Checks { get; set; } = null;

        /// <summary>
        /// Bank name, matching the bank code of the request
        /// </summary>
        public string NewBankName { get; set; } = null;

        /// <summary>
        /// Reformatted account number according to local clearing rules
        /// </summary>
        public string ReformattedAccountNumber { get; set; } = null;

        /// <summary>
        /// Reformatted bank code according to local clearing rules
        /// </summary>
        public string ReformattedBankCode { get; set; } = null;

        /// <summary>
        /// Reformatted branch code according to local clearing rules
        /// </summary>
        public string ReformattedBranchCode { get; set; } = null;
    }
}
