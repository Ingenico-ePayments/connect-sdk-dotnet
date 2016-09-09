/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_ValidationBankAccountOutput">ValidationBankAccountOutput</a>
    /// </summary>
    public class ValidationBankAccountOutput
    {
        public IList<ValidationBankAccountCheck> Checks { get; set; } = null;

        public string NewBankName { get; set; } = null;

        public string ReformattedAccountNumber { get; set; } = null;

        public string ReformattedBankCode { get; set; } = null;

        public string ReformattedBranchCode { get; set; } = null;
    }
}
