/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Services.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services
{
    public class BankDetailsResponse
    {
        /// <summary>
        /// Object that holds the Basic Bank Account Number (BBAN) data
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; } = null;

        /// <summary>
        /// Object that holds the International Bank Account Number (IBAN) data
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;

        /// <summary>
        /// Object that holds the reformatted bank account data
        /// </summary>
        public BankData BankData { get; set; } = null;

        /// <summary>
        /// Object that holds all the SWIFT routing information
        /// </summary>
        public Swift Swift { get; set; } = null;
    }
}
