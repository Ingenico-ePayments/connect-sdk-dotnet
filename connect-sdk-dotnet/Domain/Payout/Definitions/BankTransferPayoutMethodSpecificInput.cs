/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    public class BankTransferPayoutMethodSpecificInput : AbstractPayoutMethodSpecificInput
    {
        /// <summary>
        /// Object containing account holder name and bank account information. This property can only be used for payouts in the UK.
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; } = null;

        /// <summary>
        /// Object containing account holder and IBAN information.
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;

        /// <summary>
        /// Object containing the details of the customer.
        /// </summary>
        public PayoutCustomer Customer { get; set; } = null;

        /// <summary>
        /// Date of the payout sent to the bank by us.
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string PayoutDate { get; set; } = null;

        /// <summary>
        /// Text to be printed on the bank account statement of the beneficiary. The maximum allowed length might differ per country. The data will be automatically truncated to the maximum allowed length.
        /// </summary>
        public string PayoutText { get; set; } = null;

        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        public string SwiftCode { get; set; } = null;
    }
}
