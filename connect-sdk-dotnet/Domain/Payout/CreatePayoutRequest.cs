/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payout.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payout
{
    public class CreatePayoutRequest
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        [Obsolete("Moved to PayoutDetails")]
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// Object containing account holder name and bank account information. This property can only be used for payouts in the UK.
        /// </summary>
        [Obsolete("Moved to BankTransferPayoutMethodSpecificInput")]
        public BankAccountBban BankAccountBban { get; set; } = null;

        /// <summary>
        /// Object containing account holder and IBAN information.
        /// </summary>
        [Obsolete("Moved to BankTransferPayoutMethodSpecificInput")]
        public BankAccountIban BankAccountIban { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for bank transfer payouts.
        /// </summary>
        public BankTransferPayoutMethodSpecificInput BankTransferPayoutMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the specific input details for card payouts.
        /// </summary>
        public CardPayoutMethodSpecificInput CardPayoutMethodSpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing the details of the customer.
        /// </summary>
        [Obsolete("Moved to PayoutDetails")]
        public PayoutCustomer Customer { get; set; } = null;

        /// <summary>
        /// Object containing information on you, the merchant
        /// </summary>
        public PayoutMerchant Merchant { get; set; } = null;

        /// <summary>
        /// Date of the payout sent to the bank by us
        /// <br />Format: YYYYMMDD
        /// </summary>
        [Obsolete("Moved to BankTransferPayoutMethodSpecificInput")]
        public string PayoutDate { get; set; } = null;

        /// <summary>
        /// Object containing the details for Create Payout Request
        /// </summary>
        public PayoutDetails PayoutDetails { get; set; } = null;

        /// <summary>
        /// Text to be printed on the bank account statement of the beneficiary. The maximum allowed length might differ per country. The data will be automatically truncated to the maximum allowed length.
        /// </summary>
        [Obsolete("Moved to BankTransferPayoutMethodSpecificInput")]
        public string PayoutText { get; set; } = null;

        /// <summary>
        /// Object that holds all reference properties that are linked to this transaction
        /// </summary>
        [Obsolete("Moved to PayoutDetails")]
        public PayoutReferences References { get; set; } = null;

        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        [Obsolete("Moved to BankTransferPayoutMethodSpecificInput")]
        public string SwiftCode { get; set; } = null;
    }
}
