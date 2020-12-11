/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services.Definitions
{
    public class BankDetails
    {
        /// <summary>
        /// Object that holds the Basic Bank Account Number (BBAN) data
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; } = null;

        /// <summary>
        /// Object that holds the International Bank Account Number (IBAN) data
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;
    }
}
