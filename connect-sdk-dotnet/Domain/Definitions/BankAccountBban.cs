/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class BankAccountBban : BankAccount
    {
        /// <summary>
        /// Bank account number
        /// </summary>
        public string AccountNumber { get; set; } = null;

        /// <summary>
        /// Bank code
        /// </summary>
        public string BankCode { get; set; } = null;

        /// <summary>
        /// Name of the bank
        /// </summary>
        public string BankName { get; set; } = null;

        /// <summary>
        /// Branch code
        /// </summary>
        public string BranchCode { get; set; } = null;

        /// <summary>
        /// Bank check digit
        /// </summary>
        public string CheckDigit { get; set; } = null;

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the country where the bank account is held For UK payouts this value is automatically set to GB as only payouts to UK accounts are supported.
        /// </summary>
        public string CountryCode { get; set; } = null;
    }
}
