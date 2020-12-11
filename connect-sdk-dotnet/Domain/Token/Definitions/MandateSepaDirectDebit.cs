/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class MandateSepaDirectDebit : MandateSepaDirectDebitWithMandateId
    {
        /// <summary>
        /// Object containing information on the creditor
        /// </summary>
        public Creditor Creditor { get; set; } = null;
    }
}
