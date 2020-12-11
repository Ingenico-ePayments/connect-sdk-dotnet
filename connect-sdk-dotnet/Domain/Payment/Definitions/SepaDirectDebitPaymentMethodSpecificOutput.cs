/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class SepaDirectDebitPaymentMethodSpecificOutput : AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Object containing the results of the fraud screening
        /// </summary>
        public FraudResults FraudResults { get; set; } = null;

        /// <summary>
        /// Output that is SEPA Direct Debit specific (i.e. the used mandate)
        /// </summary>
        public PaymentProduct771SpecificOutput PaymentProduct771SpecificOutput { get; set; } = null;

        /// <summary>
        /// ID of the token. This property is populated for the GlobalCollect payment platform when the payment was done with a token or when the payment was tokenized.
        /// </summary>
        public string Token { get; set; } = null;
    }
}
