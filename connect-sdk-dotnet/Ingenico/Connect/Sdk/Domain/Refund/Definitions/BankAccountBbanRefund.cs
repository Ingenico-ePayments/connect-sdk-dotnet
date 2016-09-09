/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_BankAccountBbanRefund">BankAccountBbanRefund</a>
    /// </summary>
    public class BankAccountBbanRefund : BankAccountBban
    {
        public string BankCity { get; set; } = null;

        public string SwiftCode { get; set; } = null;
    }
}
