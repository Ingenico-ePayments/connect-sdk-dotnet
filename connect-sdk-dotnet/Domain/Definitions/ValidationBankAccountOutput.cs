/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class ValidationBankAccountOutput
    {
        public IList<ValidationBankAccountCheck> Checks { get; set; } = null;

        public string NewBankName { get; set; } = null;

        public string ReformattedAccountNumber { get; set; } = null;

        public string ReformattedBankCode { get; set; } = null;

        public string ReformattedBranchCode { get; set; } = null;
    }
}
