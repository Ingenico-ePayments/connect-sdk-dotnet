/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class TokenNonSepaDirectDebitPaymentProduct705SpecificData
    {
        /// <summary>
        /// Core reference number for the direct debit instruction in UK
        /// </summary>
        public string AuthorisationId { get; set; } = null;

        /// <summary>
        /// Object containing account holder name and bank account information
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; } = null;
    }
}
