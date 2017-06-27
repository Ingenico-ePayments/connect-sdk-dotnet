/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
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
