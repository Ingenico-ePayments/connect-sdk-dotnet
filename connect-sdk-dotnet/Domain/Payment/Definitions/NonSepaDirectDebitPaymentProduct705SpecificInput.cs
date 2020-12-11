/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class NonSepaDirectDebitPaymentProduct705SpecificInput
    {
        /// <summary>
        /// Core reference number for the direct debit instruction in UK
        /// </summary>
        public string AuthorisationId { get; set; } = null;

        /// <summary>
        /// Object containing account holder name and bank account information
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>first-payment - First payment direct debit</description></item>
        ///   <item><description>nth-payment - Direct Debit (n-th payment)</description></item>
        ///   <item><description>re-presented - Re-presented direct debit (after failed attempt)</description></item>
        ///   <item><description>final-payment - Final payment direct debit</description></item>
        ///   <item><description>new-or-reinstated - (zero N) New or reinstated direct debit instruction</description></item>
        ///   <item><description>cancellation - (zero C) Cancellation of direct debit instruction</description></item>
        ///   <item><description>conversion-of-paper-DDI-to-electronic-DDI - (zero S) Conversion of paper DDI to electronic DDI (only used once, when migrating from traditional direct debit to AUDDIS</description></item>
        /// </list>
        /// </summary>
        public string TransactionType { get; set; } = null;
    }
}
