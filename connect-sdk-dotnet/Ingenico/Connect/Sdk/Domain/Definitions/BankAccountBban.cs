/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_BankAccountBban">BankAccountBban</a>
    /// </summary>
    public class BankAccountBban : BankAccount
    {
        public string AccountNumber { get; set; } = null;

        public string BankCode { get; set; } = null;

        public string BankName { get; set; } = null;

        public string BranchCode { get; set; } = null;

        public string CheckDigit { get; set; } = null;

        public string CountryCode { get; set; } = null;
    }
}
