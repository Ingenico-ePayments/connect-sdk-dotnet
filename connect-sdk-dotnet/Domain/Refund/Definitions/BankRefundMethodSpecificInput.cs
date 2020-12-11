/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund.Definitions
{
    public class BankRefundMethodSpecificInput
    {
        /// <summary>
        /// Object that holds the Basic Bank Account Number (BBAN) data
        /// </summary>
        public BankAccountBbanRefund BankAccountBban { get; set; } = null;

        /// <summary>
        /// Object that holds the International Bank Account Number (IBAN) data
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the country where money will be refunded to
        /// </summary>
        public string CountryCode { get; set; } = null;
    }
}
