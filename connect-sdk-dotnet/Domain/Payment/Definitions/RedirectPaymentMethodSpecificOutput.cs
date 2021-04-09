/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Object that holds the Basic Bank Account Number (BBAN) data
        /// </summary>
        public BankAccountBban BankAccountBban { get; set; } = null;

        /// <summary>
        /// Object containing account holder name and IBAN information
        /// </summary>
        public BankAccountIban BankAccountIban { get; set; } = null;

        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank or even branch. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        public string Bic { get; set; } = null;

        /// <summary>
        /// Object containing the results of the fraud screening
        /// </summary>
        public FraudResults FraudResults { get; set; } = null;

        /// <summary>
        /// PostFinance Card (payment product 3201) specific details
        /// </summary>
        public PaymentProduct3201SpecificOutput PaymentProduct3201SpecificOutput { get; set; } = null;

        /// <summary>
        /// Trustly (payment product 806) specific details
        /// </summary>
        public PaymentProduct806SpecificOutput PaymentProduct806SpecificOutput { get; set; } = null;

        /// <summary>
        /// Sofort (payment product 836) specific details
        /// </summary>
        public PaymentProduct836SpecificOutput PaymentProduct836SpecificOutput { get; set; } = null;

        /// <summary>
        /// PayPal (payment product 840) specific details
        /// </summary>
        public PaymentProduct840SpecificOutput PaymentProduct840SpecificOutput { get; set; } = null;

        /// <summary>
        /// ID of the token. This property is populated when the payment was done with a token or when the payment was tokenized.
        /// </summary>
        public string Token { get; set; } = null;
    }
}
