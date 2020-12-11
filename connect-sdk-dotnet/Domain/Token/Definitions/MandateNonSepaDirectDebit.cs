/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class MandateNonSepaDirectDebit
    {
        /// <summary>
        /// Object containing specific data for Direct Debit UK
        /// </summary>
        public TokenNonSepaDirectDebitPaymentProduct705SpecificData PaymentProduct705SpecificData { get; set; } = null;

        /// <summary>
        /// Object containing specific data for ACH
        /// </summary>
        public TokenNonSepaDirectDebitPaymentProduct730SpecificData PaymentProduct730SpecificData { get; set; } = null;
    }
}
