/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class NonSepaDirectDebitPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        /// <summary>
        /// Direct Debit payment collection date
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateCollect { get; set; } = null;

        /// <summary>
        /// Descriptor intended to identify the transaction on the customer's bank statement
        /// </summary>
        public string DirectDebitText { get; set; } = null;

        /// <summary>
        /// Indicates if this transaction is of a one-off or a recurring type 
        /// <list type="bullet">
        ///   <item><description>true - This is recurring</description></item>
        ///   <item><description>false - This is one-off</description></item>
        /// </list>
        /// </summary>
        public bool? IsRecurring { get; set; } = null;

        /// <summary>
        /// Object containing UK Direct Debit specific details
        /// </summary>
        public NonSepaDirectDebitPaymentProduct705SpecificInput PaymentProduct705SpecificInput { get; set; } = null;

        /// <summary>
        /// Object containing ACH specific details
        /// </summary>
        public NonSepaDirectDebitPaymentProduct730SpecificInput PaymentProduct730SpecificInput { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>first = This transaction is the first of a series of recurring transactions</description></item>
        ///   <item><description>recurring = This transaction is a subsequent transaction in a series of recurring transactions</description></item>
        ///   <item><description>last = This transaction is the last transaction of a series of recurring transactions</description></item>
        /// </list>
        /// </summary>
        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - The payment requires approval before the funds will be captured using the Approve payment or Capture payment API.</description></item>
        ///   <item><description>false - The payment does not require approval, and the funds will be captured automatically.</description></item>
        /// </list>
        /// </summary>
        public bool? RequiresApproval { get; set; } = null;

        /// <summary>
        /// ID of the stored token that contains the bank account details to be debited
        /// </summary>
        public string Token { get; set; } = null;

        /// <summary>
        /// Indicates if this transaction should be tokenized 
        /// <list type="bullet">
        ///   <item><description>true - Tokenize the transaction</description></item>
        ///   <item><description>false - Do not tokenize the transaction, unless it would be tokenized by other means such as auto-tokenization of recurring payments.</description></item>
        /// </list>
        /// </summary>
        public bool? Tokenize { get; set; } = null;
    }
}
