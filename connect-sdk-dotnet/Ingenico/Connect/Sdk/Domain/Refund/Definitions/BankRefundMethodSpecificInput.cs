/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_BankRefundMethodSpecificInput">BankRefundMethodSpecificInput</a>
    /// </summary>
    public class BankRefundMethodSpecificInput
    {
        public BankAccountBbanRefund BankAccountBban { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;

        public string CountryCode { get; set; } = null;
    }
}
