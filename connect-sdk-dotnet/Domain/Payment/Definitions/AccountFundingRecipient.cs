/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class AccountFundingRecipient
    {
        /// <summary>
        /// Should be populated with the value of the corresponding accountNumberType of the recipient.
        /// </summary>
        public string AccountNumber { get; set; } = null;

        /// <summary>
        /// Defines the account number type of the recipient. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>cash = Mode of payment is cash to the recipient.</description></item>
        ///   <item><description>walletId = Digital wallet ID.</description></item>
        ///   <item><description>routingNumber = Routing Transit Number is a code used by financial institutions to identify other financial institutions.</description></item>
        ///   <item><description>iban = International Bank Account Number, is a standard international numbering system for identifying bank accounts.</description></item>
        ///   <item><description>bicNumber = Bank Identification Code is a number that is used to identify a specific bank.</description></item>
        /// </list>
        /// </summary>
        public string AccountNumberType { get; set; } = null;

        /// <summary>
        /// Object containing the address details of the recipient of an account funding transaction.
        /// </summary>
        public Address Address { get; set; } = null;

        /// <summary>
        /// The date of birth of the recipient
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateOfBirth { get; set; } = null;

        /// <summary>
        /// Object containing the name details of the recipient of an account funding transaction.
        /// </summary>
        public AfrName Name { get; set; } = null;

        /// <summary>
        /// Either partialPan or accountnumber is required for merchants that use Merchant Category Code (MCC) 6012 for transactions involving UK costumers.
        /// </summary>
        public string PartialPan { get; set; } = null;
    }
}
